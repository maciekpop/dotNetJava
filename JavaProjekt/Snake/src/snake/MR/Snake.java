package snake.MR;

import javax.swing.*;
import javax.swing.Timer;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.io.File;
import java.util.*;



public class Snake implements ActionListener, KeyListener {
    
    public  JFrame jFrame;

    public  RenderPanel renderPanel;

    public Timer timer = new Timer(20, this);

    public ArrayList<Point> snakeParts = new ArrayList<Point>();

    public static final int UP = 0, DOWN = 1, LEFT = 2, RIGHT = 3, SCALE = 10;

    public int ticks = 0, direction = DOWN, score, tailLength, highscore;

    private String bestResultNick;

    public Point head, scorePoint;

    public Random random;

    Dimension dim;

    public boolean over = false, paused;

    QuitListener quitListener = new QuitListener();
    StartListener startListener = new StartListener();
    MusicListener musicListener = new MusicListener();
    HighScoreListener highScoreListener = new HighScoreListener();

    public RobsPanel robsonPanel;

    JButton startButton, highestScoreButton, musicButton, quitButton;

    Font fontButton = new Font("Times New Roman", Font.PLAIN, 40);

    String filepath;

    MusicStuff musicStuff;

    JLabel pauseLbl;

    public Snake(){

        dim = Toolkit.getDefaultToolkit().getScreenSize();
        jFrame = new JFrame("Snake");
        jFrame.setVisible(true);
        jFrame.addKeyListener(this);
        ticks = 0;
        jFrame.setSize(800, 800);
        jFrame.setLocation(dim.width / 2 - jFrame.getWidth()/2, dim.height / 2 - jFrame.getHeight()/2);
        jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        filepath = new File( "Music/Mozart - Turkish March.wav").getAbsolutePath();
        musicStuff = new MusicStuff();
        setButtons();
        robsonPanel.setLayout(null);
        robsonPanel.add(startButton);
        robsonPanel.add(highestScoreButton);
        robsonPanel.add(musicButton);
        robsonPanel.add(quitButton);
        jFrame.add(robsonPanel);
        highscore = 0;

    }

    public void setButtons()
    {
        startButton = new JButton("Start");
        startButton.setBackground(Color.BLACK);
        startButton.setForeground(Color.PINK);
        startButton.addActionListener(startListener);
        startButton.setFont(fontButton);
        startButton.setBounds(300,150,200,100);
        startButton.setFocusable(false);
        highestScoreButton = new JButton("High Score");
        highestScoreButton.setBackground(Color.BLACK);
        highestScoreButton.setForeground(Color.PINK);
        highestScoreButton.addActionListener(highScoreListener);
        highestScoreButton.setFont(fontButton);
        highestScoreButton.setBounds(285,275,240,100);
        highestScoreButton.setFocusable(false);
        musicButton = new JButton("Music");
        musicButton.setBackground(Color.BLACK);
        musicButton.setForeground(Color.PINK);
        musicButton.addActionListener(musicListener);
        musicButton.setFont(fontButton);
        musicButton.setBounds(310,400,180,100);
        musicButton.setFocusable(false);
        quitButton = new JButton("Quit");
        quitButton.setBackground(Color.BLACK);
        quitButton.setForeground(Color.PINK);
        quitButton.addActionListener(quitListener);
        quitButton.setFont(fontButton);
        quitButton.setBounds(320,525,160,100);
        quitButton.setFocusable(false);
        robsonPanel  = new RobsPanel();
    }






    public void startGame(){


            over = false;
            paused = false;
            score = 0;
            tailLength = 2;
            direction = DOWN;
            head = new Point(0, -1);
            random = new Random();
            snakeParts.clear();
            scorePoint = new Point(random.nextInt(77), random.nextInt(75));
            timer.start();




    }

    @Override
    public void actionPerformed(ActionEvent e) {

            renderPanel.repaint();
            ticks++;

            if((over)&&(score>highscore))
            {

                String nick = JOptionPane.showInputDialog(jFrame, "You set new high score. What's your nick?");

                // get the user's input. note that if they press Cancel, 'name' will be null
                if (nick!=null) {
                    highscore = score;
                    bestResultNick = nick;

                    startGame();
                }
                else {
                    startGame();
                }

            }

            if (ticks % 2 == 0 && head != null && over != true && !paused) {

                snakeParts.add(new Point(head.x, head.y));

                if (direction == UP && noTailAt(head.x, head.y - 1)) {

                    if (head.y - 1 >= 0) {
                        head = new Point(head.x, head.y - 1);

                    } else {
                        over = true;
                    }


                }
                if (direction == DOWN && noTailAt(head.x, head.y + 1)) {
                    if (head.y + 1 < 76) {

                        head = new Point(head.x, head.y + 1);

                    } else {
                        over = true;
                    }
                }
                if (direction == RIGHT && noTailAt(head.x + 1, head.y)) {
                    if (head.x + 1 < 78) {

                        head = new Point(head.x + 1, head.y);

                    } else {
                        over = true;
                    }
                }
                if (direction == LEFT && noTailAt(head.x - 1, head.y)) {

                    if (head.x - 1 >= 0) {

                        head = new Point(head.x - 1, head.y);


                    } else {
                        over = true;
                    }
                }

                if (snakeParts.size() > tailLength) {
                    snakeParts.remove(0);
                }

                if (scorePoint != null) {
                    if (head.x == scorePoint.x && head.y == scorePoint.y) {
                        score += 10;
                        tailLength++;
                        scorePoint.setLocation(random.nextInt(77), random.nextInt(75));
                    }
                }

            }

    }

    private boolean noTailAt(int x, int y) {

        for(Point point : snakeParts)
        {
            if(point.equals(new Point(x,y)))
            {
                return false;
            }
        }

        return true;
    }


    public static void main(String[] args){
         Snake snake = new Snake();





    }


    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {

            int i = e.getKeyCode();
            if (i == KeyEvent.VK_A && i != KeyEvent.VK_S && i != KeyEvent.VK_W && i != KeyEvent.VK_D && direction != RIGHT) {

                direction = LEFT;

            }
            if (i == KeyEvent.VK_D && i!= KeyEvent.VK_A && i != KeyEvent.VK_S && i != KeyEvent.VK_W && direction != LEFT) {
                direction = RIGHT;
            }
            if (i == KeyEvent.VK_W && i != KeyEvent.VK_A && i != KeyEvent.VK_S && i != KeyEvent.VK_D && direction != DOWN) {

                direction = UP;

            }
            if (i == KeyEvent.VK_S && i != KeyEvent.VK_A && i != KeyEvent.VK_W && i != KeyEvent.VK_D && direction != UP) {

                 direction = DOWN;

            }

            if (i == KeyEvent.VK_SPACE) {
                if (over) {
                    startGame();
                } else {
                    paused = !paused;
                    if (paused == true)
                    {

                        pauseLbl = new JLabel("Paused");
                        pauseLbl.setBounds(240, 250, 400, 150);
                        pauseLbl.setFont(new Font("Verdana", Font.BOLD, 80));
                        pauseLbl.setVisible(true);
                        pauseLbl.setForeground(Color.WHITE);
                        renderPanel.add(pauseLbl);
                    }
                    else
                    {
                        renderPanel.remove(pauseLbl);
                    }
                }
            }

        if (i == KeyEvent.VK_ESCAPE) {
            robsonPanel = new RobsPanel();
            robsonPanel.setLayout(null);
            robsonPanel.add(startButton);
            robsonPanel.add(highestScoreButton);
            robsonPanel.add(musicButton);
            robsonPanel.add(quitButton);
            renderPanel.setVisible(false);
            jFrame.remove(renderPanel);
            jFrame.add(robsonPanel);


        }
    }


    @Override
    public void keyReleased(KeyEvent e) {

    }


    public class StartListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e) {
            create();
        }
    }
    public void create()
    {
        robsonPanel.setVisible(false);
        jFrame.remove(robsonPanel);
        renderPanel = new RenderPanel();
        jFrame.add(renderPanel);
        startGame();

    }

    public class HighScoreListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            bestResult();
        }
    }
    public void bestResult()
    {
        JOptionPane.showMessageDialog(jFrame,
                        "Highest score: " + highscore + "-" + bestResultNick,
                        "High score", JOptionPane.INFORMATION_MESSAGE
                        );

    }


    public class MusicListener implements ActionListener
    {
        @Override
        public void actionPerformed(ActionEvent e) {
            music();
        }
    }

    public void music()
    {
        if (JOptionPane.showConfirmDialog(jFrame, "Mozart?", "Music",
                JOptionPane.YES_NO_OPTION) == JOptionPane.YES_OPTION) {
                musicStuff.playMusic(filepath);
        } else {
            musicStuff.stopMusic();
        }
    }



    public class QuitListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            quit();
        }
    }
    public void quit()
    {
        jFrame.dispose();
        System.exit(0);

    }


    public class RenderPanel extends JPanel {

        @Override
        protected void paintComponent(Graphics g) {
            super.paintComponent(g);

            g.setColor(Color.BLACK);
            g.fillRect(0,0, 800, 800);
            g.setColor(Color.white);
            for(Point point : snakeParts )
            {

                g.fillRect(point.x * SCALE, point.y * SCALE, SCALE, SCALE);
            }
            g.fillRect(head.x * Snake.SCALE, head.y * SCALE, SCALE, SCALE);

            g.setColor(Color.RED);
            g.fillRect(scorePoint.x * Snake.SCALE, scorePoint.y * SCALE, SCALE, SCALE);

            String string = "Score: " + score + ", Length: " + tailLength;
            g.setColor(Color.green);
            g.drawString(string, 340,20);

        }
    }
}

package snake.MR;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.security.Key;
import java.util.ArrayList;
import java.util.Random;

public class Snake implements ActionListener, KeyListener {

    public JFrame jFrame;

    public RenderPanel renderPanel;

    public static Snake snake;

    public Timer timer = new Timer(20, this);

    public ArrayList<Point> snakeParts = new ArrayList<Point>();

    public static final int UP = 0, DOWN = 1, LEFT = 2, RIGHT = 3, SCALE = 10;

    public int ticks = 0, direction = DOWN, score, tailLength = 10;

    public Point head, cherry;

    public Random random;

    Dimension dim;

    public boolean over = false;

    public Snake(){
        dim = Toolkit.getDefaultToolkit().getScreenSize();
        jFrame = new JFrame("Snake");
        jFrame.setVisible(true);
        jFrame.setSize(800, 800);
        jFrame.setLocation(dim.width / 2 - jFrame.getWidth()/2, dim.height / 2 - jFrame.getHeight()/2);
        jFrame.add(renderPanel = new RenderPanel());
        jFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jFrame.addKeyListener(this);
        startGame();

    }

    public void startGame(){
        over = false;
        score = 0;
        tailLength = 0;
        direction = DOWN;
        head = new Point(0,-1);
        random = new Random();
        snakeParts.clear();
        cherry = new Point(dim.width/SCALE, dim.height/SCALE);

        for (int i =0; i < tailLength; i++)
        {
            snakeParts.add(new Point(head.x, head.y));
        }

        timer.start();

    }

    @Override
    public void actionPerformed(ActionEvent e) {

        renderPanel.repaint();
        ticks++;

        if(ticks % 10 == 0 && head != null && over != true){
            if(direction == UP) {

                if(head.y - 1 >=0){
                    head = new Point(head.x, head.y - 1);
                }
                else
                {
                    over = true;
                }


            }
            if(direction == DOWN) {
                if(head.y + 1 < dim.height / SCALE) {

                   head = new Point(head.x, head.y + 1);

                }
                else
                {
                    over = true;
                }
            }
            if(direction == RIGHT) {
                if(head.x + 1 < dim.width /SCALE) {

                    head = new Point(head.x + 1, head.y);

                }
                else
                 {
                    over = true;
                }
            }
            if(direction == LEFT) {
                if(head.x - 1 >=0) {

                    head = new Point(head.x - 1, head.y );

                }
                else
                {
                     over = true;
                }
            }

            snakeParts.add(new Point(head.x, head.y));

  /*          for(int i =0; i < tailLength; i++){
                snakeParts.remove(i);
            }
*/


            if(cherry != null) {
                if (head.x == cherry.x && head.y == cherry.y)
                {
                    score += 10;
                    tailLength++;
                    cherry.setLocation(dim.width/SCALE, dim.height/SCALE);
                }
            }

            }

    }




    public static void main(String[] args){
        snake = new Snake();

    }


    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {
        int i = e.getKeyCode();
        if(i == KeyEvent.VK_A && direction != RIGHT)
        {
            direction = LEFT;
        }
        if(i == KeyEvent.VK_D && direction != LEFT)
        {
            direction = RIGHT;
        }
        if(i == KeyEvent.VK_W && direction != DOWN)
        {
            direction = UP;
        }
        if(i == KeyEvent.VK_S && direction != UP)
        {
            direction = DOWN;
        }

        if(i == KeyEvent.VK_SPACE && over)
        {
            startGame();
        }
    }

    @Override
    public void keyReleased(KeyEvent e) {

    }
}

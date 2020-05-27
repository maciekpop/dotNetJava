package snake.MR;

import javax.swing.*;
import java.awt.*;

public class RenderPanel extends JPanel {




    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.setColor(Color.BLACK);
        g.fillRect(0,0, 800, 800);
        Snake snake = Snake.snake;
        g.setColor(Color.white);
        for(Point point : snake.snakeParts )
        {

            g.fillRect(point.x * Snake.SCALE, point.y * Snake.SCALE, Snake.SCALE, Snake.SCALE);
        }
        g.fillRect(snake.head.x * Snake.SCALE, snake.head.y * Snake.SCALE, Snake.SCALE, Snake.SCALE);

        g.setColor(Color.RED);
        g.fillRect(snake.scorePoint.x * Snake.SCALE, snake.scorePoint.y * Snake.SCALE, Snake.SCALE, Snake.SCALE);

        String string = "Score: " + snake.score + ", Length: " + snake.tailLength;
        g.setColor(Color.green);
        //g.drawString(string, (int)(snake.dim.getWidth() / 2 - string.length() ), 20);
        g.drawString(string, 340,20);

    }
}

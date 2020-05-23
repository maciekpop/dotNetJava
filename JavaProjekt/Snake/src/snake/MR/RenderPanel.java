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

    }
}

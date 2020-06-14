package snake.MR;

import javax.swing.*;
import java.awt.*;

public class MenuPanel extends JPanel {

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.setColor(Color.BLACK);
        g.fillRect(0,0, 800, 800);

        Graphics2D graphics2D = (Graphics2D) g;

        Font fnt0 = new Font("arial", Font.BOLD, 80);
        g.setFont(fnt0);
        g.setColor(Color.white);
        g.drawString("SNAKE", 260,100);

    }
}

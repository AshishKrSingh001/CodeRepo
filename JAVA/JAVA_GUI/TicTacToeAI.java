import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class TicTacToeAI extends JFrame implements ActionListener {
    private final JButton[][] buttons = new JButton[3][3];
    private final char[][] board = new char[3][3];
    private final char HUMAN = 'X';
    private final char AI = 'O';

    public TicTacToeAI() {
        setTitle("Tic Tac Toe - AI (Minimax)");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new GridLayout(3, 3));

        Font font = new Font("Arial", Font.BOLD, 60);

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                buttons[i][j] = new JButton("");
                buttons[i][j].setFont(font);
                buttons[i][j].setFocusPainted(false);
                buttons[i][j].addActionListener(this);
                add(buttons[i][j]);
                board[i][j] = ' ';
            }
        }

        setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        JButton buttonClicked = (JButton) e.getSource();

        // Human move
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (buttonClicked == buttons[i][j] && board[i][j] == ' ') {
                    board[i][j] = HUMAN;
                    buttons[i][j].setText(String.valueOf(HUMAN));
                    buttons[i][j].setEnabled(false);

                    if (checkWin(HUMAN)) {
                        JOptionPane.showMessageDialog(this, "You Win!");
                        resetBoard();
                        return;
                    } else if (isFull()) {
                        JOptionPane.showMessageDialog(this, "It's a Draw!");
                        resetBoard();
                        return;
                    }

                    // AI move
                    Move best = findBestMove();
                    board[best.row][best.col] = AI;
                    buttons[best.row][best.col].setText(String.valueOf(AI));
                    buttons[best.row][best.col].setEnabled(false);

                    if (checkWin(AI)) {
                        JOptionPane.showMessageDialog(this, "AI Wins!");
                        resetBoard();
                        return;
                    } else if (isFull()) {
                        JOptionPane.showMessageDialog(this, "It's a Draw!");
                        resetBoard();
                        return;
                    }
                }
            }
        }
    }

    // Minimax algorithm
    private int minimax(char[][] board, int depth, boolean isMax) {
        int score = evaluate(board);
        if (score == 10) return score - depth;
        if (score == -10) return score + depth;
        if (isFull()) return 0;

        if (isMax) {
            int best = Integer.MIN_VALUE;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (board[i][j] == ' ') {
                        board[i][j] = AI;
                        best = Math.max(best, minimax(board, depth + 1, false));
                        board[i][j] = ' ';
                    }
                }
            }
            return best;
        } else {
            int best = Integer.MAX_VALUE;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (board[i][j] == ' ') {
                        board[i][j] = HUMAN;
                        best = Math.min(best, minimax(board, depth + 1, true));
                        board[i][j] = ' ';
                    }
                }
            }
            return best;
        }
    }

    private Move findBestMove() {
        int bestVal = Integer.MIN_VALUE;
        Move bestMove = new Move(-1, -1);

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (board[i][j] == ' ') {
                    board[i][j] = AI;
                    int moveVal = minimax(board, 0, false);
                    board[i][j] = ' ';
                    if (moveVal > bestVal) {
                        bestMove.row = i;
                        bestMove.col = j;
                        bestVal = moveVal;
                    }
                }
            }
        }
        return bestMove;
    }

    private int evaluate(char[][] b) {
        // Rows
        for (int i = 0; i < 3; i++) {
            if (b[i][0] == b[i][1] && b[i][1] == b[i][2]) {
                if (b[i][0] == AI) return +10;
                else if (b[i][0] == HUMAN) return -10;
            }
        }
        // Columns
        for (int i = 0; i < 3; i++) {
            if (b[0][i] == b[1][i] && b[1][i] == b[2][i]) {
                if (b[0][i] == AI) return +10;
                else if (b[0][i] == HUMAN) return -10;
            }
        }
        // Diagonals
        if (b[0][0] == b[1][1] && b[1][1] == b[2][2]) {
            if (b[0][0] == AI) return +10;
            else if (b[0][0] == HUMAN) return -10;
        }
        if (b[0][2] == b[1][1] && b[1][1] == b[2][0]) {
            if (b[0][2] == AI) return +10;
            else if (b[0][2] == HUMAN) return -10;
        }
        return 0;
    }

    private boolean checkWin(char player) {
        for (int i = 0; i < 3; i++)
            if (board[i][0] == player && board[i][1] == player && board[i][2] == player)
                return true;
        for (int j = 0; j < 3; j++)
            if (board[0][j] == player && board[1][j] == player && board[2][j] == player)
                return true;
        if (board[0][0] == player && board[1][1] == player && board[2][2] == player)
            return true;
        if (board[0][2] == player && board[1][1] == player && board[2][0] == player)
            return true;
        return false;
    }

    private boolean isFull() {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i][j] == ' ')
                    return false;
        return true;
    }

    private void resetBoard() {
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                board[i][j] = ' ';
                buttons[i][j].setText("");
                buttons[i][j].setEnabled(true);
            }
        }
    }

    private static class Move {
        int row, col;
        Move(int r, int c) { row = r; col = c; }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(TicTacToeAI::new);
    }
}

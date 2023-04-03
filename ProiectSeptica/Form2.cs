using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProiectSeptica
{
    public partial class GameEnvironment : Form
    {
        private PictureBox secondCardBox;
        private PictureBox thirdCardBox;
        private PictureBox fourthCardBox;
        private PictureBox fifthCardBox;
        private PictureBox sixthCardBox;
        private PictureBox seventhCardBox;
        private PictureBox eighthCardBox;
        private Label playerTwo;
        private Label playerOne;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblDropHerePlayer1;
        private Label lblDropHerePlayer2;
        private PictureBox firstCardBox;
        private Player player1;
        private Player player2;
        private Deck deck;
        private string currentPlayer;
        private PictureBox currentCard;
        private Label player2points;
        private Label player1points;
        private Card firstPlayerCard;
        private Card secondPlayerCard;
        private int countCardsPlayed;
        private Label secondPlayerScoreLabel;
        private Label firstPlayerScoreLabel;
        private Label winnerLabel;
        private Rule gameRules;

        public GameEnvironment()
        {
            InitializeComponent();

        }

        private void GameEnvironment_Load(object sender, EventArgs e)
        {
            player1 = new Player("Player1");
            player2 = new Player("Player2");
            gameRules = new Rule();
            countCardsPlayed = 0;
            deck = new Deck();
            
            
            for (int i = 0; i < 4; i++)
            {
                Card randomCard = deck.getCard();
                player1.setCard(randomCard);
            }
            for (int i = 0; i < 4; i++)
            {
                Card randomCard = deck.getCard();
                player2.setCard(randomCard);
            }
            currentPlayer = player1.getId();

            firstCardBox.BackgroundImage = player1.getCard(0).getCardImage();
            secondCardBox.BackgroundImage = player1.getCard(1).getCardImage();
            thirdCardBox.BackgroundImage = player1.getCard(2).getCardImage();
            fourthCardBox.BackgroundImage = player1.getCard(3).getCardImage();
            fifthCardBox.BackgroundImage = player2.getCard(0).getCardImage();
            sixthCardBox.BackgroundImage = player2.getCard(1).getCardImage();
            seventhCardBox.BackgroundImage = player2.getCard(2).getCardImage();
            eighthCardBox.BackgroundImage = player2.getCard(3).getCardImage();
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            lblDropHerePlayer1.Visible = false;

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEnvironment));
            this.firstCardBox = new System.Windows.Forms.PictureBox();
            this.secondCardBox = new System.Windows.Forms.PictureBox();
            this.thirdCardBox = new System.Windows.Forms.PictureBox();
            this.fourthCardBox = new System.Windows.Forms.PictureBox();
            this.fifthCardBox = new System.Windows.Forms.PictureBox();
            this.sixthCardBox = new System.Windows.Forms.PictureBox();
            this.seventhCardBox = new System.Windows.Forms.PictureBox();
            this.eighthCardBox = new System.Windows.Forms.PictureBox();
            this.playerTwo = new System.Windows.Forms.Label();
            this.playerOne = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDropHerePlayer1 = new System.Windows.Forms.Label();
            this.lblDropHerePlayer2 = new System.Windows.Forms.Label();
            this.player2points = new System.Windows.Forms.Label();
            this.player1points = new System.Windows.Forms.Label();
            this.secondPlayerScoreLabel = new System.Windows.Forms.Label();
            this.firstPlayerScoreLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seventhCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eighthCardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // firstCardBox
            // 
            this.firstCardBox.Location = new System.Drawing.Point(186, 396);
            this.firstCardBox.Name = "firstCardBox";
            this.firstCardBox.Size = new System.Drawing.Size(62, 84);
            this.firstCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstCardBox.TabIndex = 0;
            this.firstCardBox.TabStop = false;
            this.firstCardBox.Tag = "0";
            this.firstCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // secondCardBox
            // 
            this.secondCardBox.Location = new System.Drawing.Point(298, 396);
            this.secondCardBox.Name = "secondCardBox";
            this.secondCardBox.Size = new System.Drawing.Size(62, 84);
            this.secondCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondCardBox.TabIndex = 1;
            this.secondCardBox.TabStop = false;
            this.secondCardBox.Tag = "1";
            this.secondCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // thirdCardBox
            // 
            this.thirdCardBox.Location = new System.Drawing.Point(414, 396);
            this.thirdCardBox.Name = "thirdCardBox";
            this.thirdCardBox.Size = new System.Drawing.Size(62, 84);
            this.thirdCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdCardBox.TabIndex = 2;
            this.thirdCardBox.TabStop = false;
            this.thirdCardBox.Tag = "2";
            this.thirdCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // fourthCardBox
            // 
            this.fourthCardBox.Location = new System.Drawing.Point(523, 396);
            this.fourthCardBox.Name = "fourthCardBox";
            this.fourthCardBox.Size = new System.Drawing.Size(62, 84);
            this.fourthCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourthCardBox.TabIndex = 3;
            this.fourthCardBox.TabStop = false;
            this.fourthCardBox.Tag = "3";
            this.fourthCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // fifthCardBox
            // 
            this.fifthCardBox.Location = new System.Drawing.Point(186, 72);
            this.fifthCardBox.Name = "fifthCardBox";
            this.fifthCardBox.Size = new System.Drawing.Size(62, 84);
            this.fifthCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fifthCardBox.TabIndex = 4;
            this.fifthCardBox.TabStop = false;
            this.fifthCardBox.Tag = "4";
            this.fifthCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // sixthCardBox
            // 
            this.sixthCardBox.Location = new System.Drawing.Point(298, 72);
            this.sixthCardBox.Name = "sixthCardBox";
            this.sixthCardBox.Size = new System.Drawing.Size(62, 84);
            this.sixthCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sixthCardBox.TabIndex = 5;
            this.sixthCardBox.TabStop = false;
            this.sixthCardBox.Tag = "5";
            this.sixthCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // seventhCardBox
            // 
            this.seventhCardBox.Location = new System.Drawing.Point(414, 72);
            this.seventhCardBox.Name = "seventhCardBox";
            this.seventhCardBox.Size = new System.Drawing.Size(62, 84);
            this.seventhCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seventhCardBox.TabIndex = 6;
            this.seventhCardBox.TabStop = false;
            this.seventhCardBox.Tag = "6";
            this.seventhCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // eighthCardBox
            // 
            this.eighthCardBox.Location = new System.Drawing.Point(523, 72);
            this.eighthCardBox.Name = "eighthCardBox";
            this.eighthCardBox.Size = new System.Drawing.Size(62, 84);
            this.eighthCardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eighthCardBox.TabIndex = 7;
            this.eighthCardBox.TabStop = false;
            this.eighthCardBox.Tag = "7";
            this.eighthCardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // playerTwo
            // 
            this.playerTwo.AutoSize = true;
            this.playerTwo.BackColor = System.Drawing.SystemColors.Info;
            this.playerTwo.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playerTwo.Location = new System.Drawing.Point(648, 106);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(124, 28);
            this.playerTwo.TabIndex = 8;
            this.playerTwo.Text = "PLAYER TWO";
            // 
            // playerOne
            // 
            this.playerOne.AutoSize = true;
            this.playerOne.BackColor = System.Drawing.SystemColors.Info;
            this.playerOne.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOne.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playerOne.Location = new System.Drawing.Point(648, 426);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(120, 28);
            this.playerOne.TabIndex = 9;
            this.playerOne.Text = "PLAYER ONE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(299, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.DragLeave += new System.EventHandler(this.pictureBox1_DragLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(414, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragDrop);
            this.pictureBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox2_DragEnter);
            this.pictureBox2.DragLeave += new System.EventHandler(this.pictureBox2_DragLeave);
            // 
            // lblDropHerePlayer1
            // 
            this.lblDropHerePlayer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDropHerePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropHerePlayer1.Location = new System.Drawing.Point(299, 184);
            this.lblDropHerePlayer1.Name = "lblDropHerePlayer1";
            this.lblDropHerePlayer1.Size = new System.Drawing.Size(62, 41);
            this.lblDropHerePlayer1.TabIndex = 12;
            this.lblDropHerePlayer1.Text = "Drop Here";
            this.lblDropHerePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDropHerePlayer2
            // 
            this.lblDropHerePlayer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDropHerePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropHerePlayer2.Location = new System.Drawing.Point(414, 184);
            this.lblDropHerePlayer2.Name = "lblDropHerePlayer2";
            this.lblDropHerePlayer2.Size = new System.Drawing.Size(62, 41);
            this.lblDropHerePlayer2.TabIndex = 13;
            this.lblDropHerePlayer2.Text = "Drop Here";
            this.lblDropHerePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDropHerePlayer2.Visible = false;
            // 
            // player2points
            // 
            this.player2points.AutoSize = true;
            this.player2points.BackColor = System.Drawing.Color.Transparent;
            this.player2points.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2points.ForeColor = System.Drawing.SystemColors.Desktop;
            this.player2points.Location = new System.Drawing.Point(12, 103);
            this.player2points.Name = "player2points";
            this.player2points.Size = new System.Drawing.Size(130, 28);
            this.player2points.TabIndex = 14;
            this.player2points.Text = "Player2Points:";
            // 
            // player1points
            // 
            this.player1points.AutoSize = true;
            this.player1points.BackColor = System.Drawing.Color.Transparent;
            this.player1points.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1points.ForeColor = System.Drawing.SystemColors.Desktop;
            this.player1points.Location = new System.Drawing.Point(14, 426);
            this.player1points.Name = "player1points";
            this.player1points.Size = new System.Drawing.Size(128, 28);
            this.player1points.TabIndex = 15;
            this.player1points.Text = "Player1Points:";
            // 
            // secondPlayerScoreLabel
            // 
            this.secondPlayerScoreLabel.AutoSize = true;
            this.secondPlayerScoreLabel.Location = new System.Drawing.Point(137, 112);
            this.secondPlayerScoreLabel.Name = "secondPlayerScoreLabel";
            this.secondPlayerScoreLabel.Size = new System.Drawing.Size(14, 16);
            this.secondPlayerScoreLabel.TabIndex = 16;
            this.secondPlayerScoreLabel.Text = "0";
            // 
            // firstPlayerScoreLabel
            // 
            this.firstPlayerScoreLabel.AutoSize = true;
            this.firstPlayerScoreLabel.Location = new System.Drawing.Point(137, 435);
            this.firstPlayerScoreLabel.Name = "firstPlayerScoreLabel";
            this.firstPlayerScoreLabel.Size = new System.Drawing.Size(14, 16);
            this.firstPlayerScoreLabel.TabIndex = 17;
            this.firstPlayerScoreLabel.Text = "0";
            // 
            // winnerLabel
            // 
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winnerLabel.Location = new System.Drawing.Point(116, 12);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(611, 94);
            this.winnerLabel.TabIndex = 18;
            this.winnerLabel.Visible = false;
            // 
            // GameEnvironment
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(803, 562);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.firstPlayerScoreLabel);
            this.Controls.Add(this.secondPlayerScoreLabel);
            this.Controls.Add(this.player1points);
            this.Controls.Add(this.player2points);
            this.Controls.Add(this.lblDropHerePlayer2);
            this.Controls.Add(this.lblDropHerePlayer1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.eighthCardBox);
            this.Controls.Add(this.seventhCardBox);
            this.Controls.Add(this.sixthCardBox);
            this.Controls.Add(this.fifthCardBox);
            this.Controls.Add(this.fourthCardBox);
            this.Controls.Add(this.thirdCardBox);
            this.Controls.Add(this.secondCardBox);
            this.Controls.Add(this.firstCardBox);
            this.Name = "GameEnvironment";
            this.Text = "Septica-PLAY";
            this.Load += new System.EventHandler(this.GameEnvironment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seventhCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eighthCardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            currentCard = (PictureBox)sender;
            currentCard.DoDragDrop(currentCard.BackgroundImage, DragDropEffects.Copy);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            int currentCardTag = int.Parse(currentCard.Tag.ToString());
            if (currentPlayer == "Player1" && currentCardTag < 4) {
                lblDropHerePlayer1.Visible = true;
                if (e.Data.GetDataPresent(DataFormats.Bitmap)) { e.Effect = DragDropEffects.Copy; }
            }
        }
        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {
            lblDropHerePlayer1.Visible = false;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            int currentCardTag = int.Parse(currentCard.Tag.ToString());
            if (currentPlayer == "Player1" && currentCardTag < 4)
            {
                lblDropHerePlayer1.Visible = false;
                Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                pictureBox1.BackgroundImage = getPicture;
                currentPlayer = player2.getId();
                currentCard.BackgroundImage = null;
                if (deck.hasCards())
                {
                    Card randomCard = deck.getCard();
                    player1.setCard(currentCardTag, randomCard);
                    currentCard.BackgroundImage = randomCard.getCardImage();
                    firstPlayerCard = player1.removeCard(currentCardTag);
                }
                else
                {
                    currentCard.Visible = false;
                    firstPlayerCard = player1.getCard(currentCardTag);
                }
                countCardsPlayed++;

                if (countCardsPlayed == 2)
                {
                    pictureBox1.BackgroundImage = null;
                    pictureBox2.BackgroundImage = null;

                    countCardsPlayed = 0;
                    currentPlayer = gameRules.getWinner(firstPlayerCard, secondPlayerCard, player1);

                    if (player1.getId() == currentPlayer)
                    {
                        player1.updateScore(firstPlayerCard.getValue(), secondPlayerCard.getValue());
                        firstPlayerScoreLabel.Text = player1.getScore().ToString();
                    }
                    else
                    {
                        player2.updateScore(firstPlayerCard.getValue(), secondPlayerCard.getValue());
                        secondPlayerScoreLabel.Text = player2.getScore().ToString();
                    }
                }

                if(player1.getScore() + player2.getScore() == 8)
                {
                    int player1Score = player1.getScore();
                    int player2Score = player2.getScore();
                    winnerLabel.Visible = true;
                    if(player1Score > player2Score)
                    {
                        winnerLabel.Text = "A castigat playerul 1!";
                    }
                    else if(player1Score < player2Score)
                    {
                        winnerLabel.Text = "A castigat playerul 2!";
                    }
                    else
                    {
                        winnerLabel.Text = "Remiza!";
                    }
                }
            }
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            int currentCardTag = int.Parse(currentCard.Tag.ToString());
            if (currentPlayer == "Player2" && currentCardTag > 3) { 
                lblDropHerePlayer2.Visible = true;
                if (e.Data.GetDataPresent(DataFormats.Bitmap)) { e.Effect = DragDropEffects.Copy; }
            }
        }

        private void pictureBox2_DragLeave(object sender, EventArgs e)
        {
            lblDropHerePlayer2.Visible = false;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            int currentCardTag = int.Parse(currentCard.Tag.ToString());
            if (currentPlayer == "Player2" && currentCardTag > 3)
            {
                lblDropHerePlayer2.Visible = false;
                Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                pictureBox2.BackgroundImage = getPicture;
                currentPlayer = player1.getId();
                currentCard.BackgroundImage = null;
                if (deck.hasCards())
                {
                    Card randomCard = deck.getCard();
                    player2.setCard(currentCardTag - 4, randomCard);
                    currentCard.BackgroundImage = randomCard.getCardImage();
                    secondPlayerCard = player2.removeCard(currentCardTag - 4);
                }
                else
                {
                    currentCard.Visible = false;
                    secondPlayerCard = player2.getCard(currentCardTag - 4);
                }
                countCardsPlayed++;

                if (countCardsPlayed == 2)
                {
                    pictureBox1.BackgroundImage = null;
                    pictureBox2.BackgroundImage = null;

                    countCardsPlayed = 0;
                    currentPlayer = gameRules.getWinner(firstPlayerCard, secondPlayerCard, player2);

                    if (player1.getId() == currentPlayer)
                    {
                        player1.updateScore(firstPlayerCard.getValue(), secondPlayerCard.getValue());
                        firstPlayerScoreLabel.Text = player1.getScore().ToString();
                    }
                    else
                    {
                        player2.updateScore(firstPlayerCard.getValue(), secondPlayerCard.getValue());
                        secondPlayerScoreLabel.Text = player2.getScore().ToString();
                    }
                }
                if (player1.getScore() + player2.getScore() == 8)
                {
                    int player1Score = player1.getScore();
                    int player2Score = player2.getScore();
                    winnerLabel.Visible = true;
                    if (player1Score > player2Score)
                    {
                        winnerLabel.Text = "A castigat playerul 1!";
                    }
                    else if (player1Score < player2Score)
                    {
                        winnerLabel.Text = "A castigat playerul 2!";
                    }
                    else
                    {
                        winnerLabel.Text = "Remiza!";
                    }
                }
            }
        }
    }
}

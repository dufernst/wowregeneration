﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRegeneration.UI
{
    class AnimatedProgressBar : PictureBox
    {
        private int startX;
        private int fullBar;

        private bool init;

        private PictureBox animation;
        private PictureBox head;

        private Timer animationTimer;
        private double animationX;

        private bool finished;

        /// <summary>
        ///     might want to look at the following for double buffering:
        ///     http://stackoverflow.com/questions/3718380/winforms-double-buffering
        /// </summary>
        public AnimatedProgressBar()
            : base()
        {
            init = false;
            finished = false;
            animation = new System.Windows.Forms.PictureBox();
            head = new System.Windows.Forms.PictureBox();
            animation.Parent = this;
            head.Parent = this;

            animation.Visible = false;
            head.Visible = false;

            head.Height = 7;
            head.BackgroundImageLayout = ImageLayout.Stretch;

            animation.Width = 12;
            animationX = 0.0;

            this.BackgroundImage = Properties.Resources.Progress_Bar_Downloading;
            animation.BackgroundImage = Properties.Resources.Progress_Bar_Downloading_Animation;
            head.BackgroundImage = Properties.Resources.Progress_Bar_Downloading_Head;
            animation.Visible = true;
            head.Visible = true;

            animationTimer = new Timer();
            // 30ish frames per second
            animationTimer.Interval = 35;
            animationTimer.Tick += UpdateAnimation;
            animationTimer.Enabled = true;
        }

        public void setProgress(double progress)
        {
            if (!init)
            {
                startX = this.Location.X;
                fullBar = this.Size.Width;
                init = true;
            }

            this.Width = (int)((progress * fullBar) / 100);
            updateHead();
        }

        private void updateHead()
        {
            if (this.Width >= 17)
            {
                head.Location = new System.Drawing.Point(this.Width - 17, 1);
                head.Width = 17;
            }
            else
            {
                head.Width = this.Width;
                head.Location = new System.Drawing.Point(0, 1);
            }
        }

        void UpdateAnimation(object sender, EventArgs e)
        {
            if (finished)
                return;

            animationX += 6;
            if (animationX + 12 > fullBar)
                animationX = 0.0;

            animation.Location = new System.Drawing.Point((int)animationX, 0);
            if (animationX + 10.0 > this.Width)
                animation.Visible = false;
            else
                animation.Visible = true;
        }

        void SetFinished()
        {
            finished = true;
            this.BackgroundImage = Properties.Resources.Progress_Bar_Not_Seeding;
            animation.Visible = false;
            head.Visible = false;
        }
    }
}

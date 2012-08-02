﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using WeifenLuo.WinFormsUI.Docking;

namespace NekoKun.UI
{
    public class LynnDockContent : DockContent
    {
        protected Color back = Color.FromArgb(191, 219, 255);

        public LynnDockContent()
        {
            this.BackColor = back;
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            SetFont(e.Control);
            base.OnControlAdded(e);
        }

        protected void SetFont(Control e)
        {
            if (e is Scintilla)
            {
                Scintilla sci = e as Scintilla;
                e.Font = Program.GetMonospaceFont();

                for (int i = 0; i < 200; i++)
                {
                    sci.Styles[i].Font = e.Font;
                }
            }
            else
                e.Font = this.Font;

            if (e is Panel || e is SplitContainer)
            {
                e.BackColor = Color.Transparent;// back1;
            }

            if (e.Controls.Count != 0)
                foreach (Control item in e.Controls)
                {
                    SetFont(item);
                }
        }
    }
}

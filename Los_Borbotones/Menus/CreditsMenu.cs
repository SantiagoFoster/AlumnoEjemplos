﻿using Microsoft.DirectX.DirectInput;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TgcViewer;
using TgcViewer.Utils._2D;
using TgcViewer.Utils.Input;

namespace AlumnoEjemplos.Los_Borbotones.Menus
{
    public class CreditsMenu:Menu
    {
        TgcText2d grupo;
        TgcText2d integrante1;
        TgcText2d integrante2;
        TgcText2d integrante3;
        TgcText2d integrante4;

        internal override void Init()
        {
            grupo = new TgcText2d();
            grupo.Text = "Los Borbotones";
            grupo.Color = Color.Crimson;
            grupo.Align = TgcText2d.TextAlign.CENTER;
            grupo.Position = new Point(0, 100);
            grupo.changeFont(new System.Drawing.Font("TimesNewRoman", 25, FontStyle.Bold));

            integrante1 = new TgcText2d();
            integrante1.Text = "Santiago Foster";
            integrante1.Color = Color.Crimson;
            integrante1.Align = TgcText2d.TextAlign.LEFT;
            integrante1.Position = new Point(300, 200);
            integrante1.changeFont(new System.Drawing.Font("TimesNewRoman", 25, FontStyle.Bold));

            integrante2 = new TgcText2d();
            integrante2.Text = "Gonzalo Furci";
            integrante2.Color = Color.Crimson;
            integrante2.Align = TgcText2d.TextAlign.LEFT;
            integrante2.Position = new Point(600, 200);
            integrante2.changeFont(new System.Drawing.Font("TimesNewRoman", 25, FontStyle.Bold));

            integrante3 = new TgcText2d();
            integrante3.Text = "Diego Quiros";
            integrante3.Color = Color.Crimson;
            integrante3.Align = TgcText2d.TextAlign.LEFT;
            integrante3.Position = new Point(300, 300);
            integrante3.changeFont(new System.Drawing.Font("TimesNewRoman", 25, FontStyle.Bold));

            integrante4 = new TgcText2d();
            integrante4.Text = "Martin Loguancio";
            integrante4.Color = Color.Crimson;
            integrante4.Align = TgcText2d.TextAlign.LEFT;
            integrante4.Position = new Point(600, 300);
            integrante4.changeFont(new System.Drawing.Font("TimesNewRoman", 25, FontStyle.Bold));

            TgcText2d backText = new TgcText2d();
            backText.Text = "Back";
            backText.Color = Color.Crimson;
            backText.Align = TgcText2d.TextAlign.LEFT;
            backText.Position = new Point(100, 450);
            backText.changeFont(new System.Drawing.Font("TimesNewRoman", 25, FontStyle.Bold));

            texts = new TgcText2d[1] { backText };
            base.Init();
        }

        internal override void Update(float elapsedTime)
        {
            base.Update(elapsedTime);
            TgcD3dInput input = GuiController.Instance.D3dInput;
            if (input.keyPressed(Key.Space) || input.keyPressed(Key.Return))
            {
                select = true;
                switch (texts[selectedText].Text)
                {
                    case "Back": MenuManager.Instance.cargarPantalla(new MainMenu());
                        break;
                }
            }
        }

        internal override void Render(float elapsedTime)
        {
            integrante1.render();
            integrante2.render();
            integrante3.render();
            integrante4.render();
            grupo.render();
            base.Render(elapsedTime);
        }

        internal override void close()
        {
            grupo.dispose();
            base.close();
        }
    }
}

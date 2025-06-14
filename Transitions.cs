using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicYearProject
{
    public class Transitions
    {
        private const int AnimationStep = 15; 
        private const int TimerInterval = 10; 

        public enum SlideDirection { Left, Right, Up, Down }

        public static void SlideForm(Form currentForm, Form newForm, SlideDirection direction)
        {
            switch (direction)
            {
                case SlideDirection.Left:
                    newForm.Location = new Point(currentForm.Right, currentForm.Top);
                    break;
                case SlideDirection.Right:
                    newForm.Location = new Point(-newForm.Width, currentForm.Top);
                    break;
            }
        }
        public static void SlideToNextForm(Form currentForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = new Point(currentForm.Right, currentForm.Top);

            newForm.Show();

            Timer slideTimer = new Timer { Interval = TimerInterval };
            slideTimer.Tick += (sender, e) =>
            {
                currentForm.Left -= AnimationStep;
                newForm.Left -= AnimationStep;

                // Если новая форма полностью вошла в экран
                if (newForm.Left <= currentForm.Left)
                {
                    slideTimer.Stop();
                    currentForm.Hide(); 
                }
            };
            slideTimer.Start();
        }

        public static void SlideBackToPreviousForm(Form currentForm, Form previousForm)
        {
            // Показываем предыдущую форму (она была скрыта)
            previousForm.Show();
            previousForm.Left = -previousForm.Width; // Ставим её слева за экраном

            // Запускаем анимацию
            Timer slideTimer = new Timer { Interval = TimerInterval };
            slideTimer.Tick += (sender, e) =>
            {
                // Сдвигаем обе формы вправо
                currentForm.Left += AnimationStep;
                previousForm.Left += AnimationStep;

                // Если предыдущая форма полностью вернулась
                if (previousForm.Left >= 0)
                {
                    slideTimer.Stop();
                    currentForm.Close(); // Закрываем текущую форму
                }
            };
            slideTimer.Start();
        }
    }
}

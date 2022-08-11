using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.KeyboardModels
{
    public class Keyboard
    {
        public Keyboard(string culture , bool capsLock)
        {
            string[] Row1Lower ;
            string[] Row1Upper ;
            string[] Row2Lower ;
            string[] Row2Upper;
            string[] Row3Lower ;
            string[] Row3Upper ;
            string[] Row4Lower ;
            string[] Row4Upper ;
            if (culture == "en")
            {
                Row1Lower = Properties.KeyboardEnglish.Row1Lower.Split(',');
                Row1Upper = Properties.KeyboardEnglish.Row1Upper.Split(',');
                Row2Lower = Properties.KeyboardEnglish.Row2Lower.Split(',');
                Row2Upper = Properties.KeyboardEnglish.Row2Upper.Split(',');
                Row3Lower = Properties.KeyboardEnglish.Row3Lower.Split(',');
                Row3Upper = Properties.KeyboardEnglish.Row3Upper.Split(',');
                Row4Lower = Properties.KeyboardEnglish.Row4Lower.Split(',');
                Row4Upper = Properties.KeyboardEnglish.Row4Upper.Split(',');
            }
            else if (culture == "am")
            {
                Row1Lower = Properties.KeyboardArmenian.Row1Lower.Split(',');
                Row1Upper = Properties.KeyboardArmenian.Row1Upper.Split(',');
                Row2Lower = Properties.KeyboardArmenian.Row2Lower.Split(',');
                Row2Upper = Properties.KeyboardArmenian.Row2Upper.Split(',');
                Row3Lower = Properties.KeyboardArmenian.Row3Lower.Split(',');
                Row3Upper = Properties.KeyboardArmenian.Row3Upper.Split(',');
                Row4Lower = Properties.KeyboardArmenian.Row4Lower.Split(',');
                Row4Upper = Properties.KeyboardArmenian.Row4Upper.Split(',');
            }
            else if (culture == "ru")
            {
                Row1Lower = Properties.KeyboardRussian.Row1Lower.Split(',');
                Row1Upper = Properties.KeyboardRussian.Row1Upper.Split(',');
                Row2Lower = Properties.KeyboardRussian.Row2Lower.Split(',');
                Row2Upper = Properties.KeyboardRussian.Row2Upper.Split(',');
                Row3Lower = Properties.KeyboardRussian.Row3Lower.Split(',');
                Row3Upper = Properties.KeyboardRussian.Row3Upper.Split(',');
                Row4Lower = Properties.KeyboardRussian.Row4Lower.Split(',');
                Row4Upper = Properties.KeyboardRussian.Row4Upper.Split(',');
            }
           else
            {
                Row1Lower = Properties.KeyboardEnglish.Row1Lower.Split(',');
                Row1Upper = Properties.KeyboardEnglish.Row1Upper.Split(',');
                Row2Lower = Properties.KeyboardEnglish.Row2Lower.Split(',');
                Row2Upper = Properties.KeyboardEnglish.Row2Upper.Split(',');
                Row3Lower = Properties.KeyboardEnglish.Row3Lower.Split(',');
                Row3Upper = Properties.KeyboardEnglish.Row3Upper.Split(',');
                Row4Lower = Properties.KeyboardEnglish.Row4Lower.Split(',');
                Row4Upper = Properties.KeyboardEnglish.Row4Upper.Split(',');
            }



            keyboardRows = new List<KeyboardRow>(); 
            var row1 = new KeyboardRow();  

            

            for (int i = 0; i < Row1Lower.Length; i++)
            {
                if (capsLock)
                {
                    row1.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row1Lower[i],
                        Upper = Row1Upper[i],
                        Symbol = Row1Upper[i]
                    });

                }
                else
                {
                    row1.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row1Lower[i],
                        Upper = Row1Upper[i],
                        Symbol = Row1Lower[i]
                    });
                }
               
            }
            keyboardRows.Add(row1);


            var row2 = new KeyboardRow();

            

            for (int i = 0; i < Row2Lower.Length; i++)
            {
                if (capsLock)
                {
                    row2.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row2Lower[i],
                        Upper = Row2Upper[i],
                        Symbol = Row2Upper[i]
                    });
                }
                else
                {
                    row2.keyboardKeys.Add(new KeyboardKey()
                    {

                        Lower = Row2Lower[i],
                        Upper = Row2Upper[i],
                        Symbol = Row2Lower[i]
                    });
                }
               
            }
            keyboardRows.Add(row2);

            var row3 = new KeyboardRow();

            

            for (int i = 0; i < Row3Lower.Length; i++)
            {
                if (capsLock)
                {
                    row3.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row3Lower[i],
                        Upper = Row3Upper[i],
                        Symbol = Row3Upper[i]
                    });
                }
                else
                {
                    row3.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row3Lower[i],
                        Upper = Row3Upper[i],
                        Symbol = Row3Lower[i]
                    });
                }
                
            }
            keyboardRows.Add(row3);



            var row4 = new KeyboardRow();

           

            for (int i = 0; i < Row4Lower.Length; i++)
            {
                if (capsLock)
                {
                    row4.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row4Lower[i],
                        Upper = Row4Upper[i],
                        Symbol = Row4Upper[i]
                    });
                }
                else
                {
                    row4.keyboardKeys.Add(new KeyboardKey()
                    {
                        Lower = Row4Lower[i],
                        Upper = Row4Upper[i],
                        Symbol = Row4Lower[i]
                    });
                }
                
            }
            keyboardRows.Add(row4);


        }
        public List<KeyboardRow> keyboardRows { get; set; }
    }
    public class KeyboardRow
    {
        public KeyboardRow()
        {
            keyboardKeys = new List<KeyboardKey>();
        }
      public List<KeyboardKey> keyboardKeys { get; set; }   
    }
    public class KeyboardKey
    {
        public string Upper { get; set; }
        public string Lower { get; set; }
        public string  Symbol { get; set; }
        public ICommand Input { get => new Models.Commands.InputPatientVisitCodeKey(); }
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tp022.ViewModel
{
    public class EntryNumerico : Xamarin.Forms.TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int parsed;
            bool validar = int.TryParse(sender.Text, out parsed);
            if (!validar)
            {
                sender.TextColor = System.Drawing.Color.Red;
            }
            else
            {
                sender.TextColor = System.Drawing.Color.Blue;
            }
        }
    }
}

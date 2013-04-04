using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puffer
{
    public class Mind
    {

        public Mind()
        {
            creationComplete = false;
            color = loadString("color");
            clothing = loadString("clothing");
            mood = loadString("mood");
        }


        private IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;

        private bool creationComplete;
        public bool CreationComplete
        {
            get
            {
                creationComplete = Convert.ToBoolean(loadString("creation"));
                return creationComplete;
            }
            set
            {
                creationComplete = value;
                saveString(Convert.ToString(creationComplete), "creation");
            }
        }
        
        private string color;
        public string Color
        {
            get
            {
                color = loadString("color");
                return color;
            }
            set
            {
                color = value;
                saveString(color, "color");
            }
        }

        private string clothing;
        public string Clothing
        {
            get
            {
                clothing = loadString("clothing");
                return clothing;
            }
            set
            {
                clothing = value;
                saveString(clothing, "clothing");
            }
        }

        private string mood;
        public string Mood
        {
            get
            {
                mood = loadString("mood");
                return mood;
            }
            set
            {
                mood = value;
                saveString(mood, "mood");
            }
        }

        private string loadString(string key)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains(key))
            {
                return (string)IsolatedStorageSettings.ApplicationSettings[key];
            }
            else return null;
        }

        private void saveString(string value, string key)
        {
            IsolatedStorageSettings.ApplicationSettings[key] = value;
            IsolatedStorageSettings.ApplicationSettings.Save();
        }
    }
}

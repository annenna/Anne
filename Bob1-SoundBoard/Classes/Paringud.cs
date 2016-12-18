using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundBoard.Model;

namespace SoundBoard.Classes
{
    public class Paringud
    {
        public static List<string> GetSuggestions( ObservableCollection<Sound> sounds,string soundName )
        {
            //SoundManager.GetAllSounds(Sounds);
           return sounds
                .Where(p => p.Name.StartsWith(soundName))
                .Select(p => p.Name)
                .ToList();

        }
        
    }
}

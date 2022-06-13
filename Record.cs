using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Z3
{
    public class Record : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly static Dictionary<string, string[]> bindedRecord
            = new Dictionary<string, string[]>()
            {
                ["Title"] = new string[] { "Title" },
                ["Director"] = new string[] { "Director" },
                ["Publisher"] = new string[] { "Publisher" },
                ["Media"] = new string[] { "Media" },
                ["Duration"] = new string[] { "Duration" },
            };
        void OnPropertyChanged(
            [CallerMemberName] string property = null,
            HashSet<string> fixedProperties = null
            )
        {
            if (fixedProperties == null)
                fixedProperties = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            fixedProperties.Add(property);

            if (bindedRecord.ContainsKey(property))
                foreach (string linkedProperty in bindedRecord[property])
                    if (!fixedProperties.Contains(linkedProperty))
                        OnPropertyChanged(linkedProperty, fixedProperties);
        }

        string
            title,
            director,
            publisher,
            media,
            duration
            ;
        public string RecordDetails => $"{title}";

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        public string Director
        {
            get => director;
            set
            {
                director = value;
                OnPropertyChanged();
            }
        }
        public string Publisher
        {
            get => publisher;
            set
            {
                publisher = value;
                OnPropertyChanged();
            }
        }
        public string Media
        {
            get => media;
            set
            {
                media = value;
                OnPropertyChanged();
            }
        }
        public string Duration
        {
            get => duration;
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }

        public Record(string title, string director, string publisher, string media, string duration)
        {
            Title = title;
            Director = director;
            Publisher = publisher;
            Media = media;
            Duration = duration;
        }
        public Record()
        {

        }
    }
}

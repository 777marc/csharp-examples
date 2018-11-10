using System.Collections.Generic;

namespace csharp_examples.Indexers
{
    public class IndexedList
    {
        private readonly Dictionary<string, string> _indexedList;

        public IndexedList(Dictionary<string, string> indexedList)
        {
            this._indexedList = indexedList;
        }

        public string this[string key]
        {
            get { 
                return _indexedList[key]; 
            }
            
            set { 
                    _indexedList[key] = value; 
            }
        }
    }
}
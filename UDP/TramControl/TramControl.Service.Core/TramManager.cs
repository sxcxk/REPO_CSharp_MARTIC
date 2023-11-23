using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramControl.Service.Core
{
    public class TramManager
    {
        private List<TramWayInformation> _tramWays;
        private static TramManager _instance=null;

        public static TramManager Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new TramManager();
                }
                return _instance;
            }
        }

        public TramManager()
        {
            _tramWays = new List<TramWayInformation>();
        }

        public void Add(TramWayInformation tramWayInformation)
        {
            _tramWays.Add(tramWayInformation);
        }

        public void RemoveTramWay(int index)
        {
            if (index > 0 && index < _tramWays.Count)
            {
                _tramWays.RemoveAt(index);
            }
        }

        public List<TramWayInformation> GetList()
        {
            return _tramWays;
        }
    }
}

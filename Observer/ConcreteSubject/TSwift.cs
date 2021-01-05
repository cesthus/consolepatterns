using Observer.Observer;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ConcreteSubject
{
    public class TSwift : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;

        public TSwift(string tweet)
        {
            this._tweet = tweet;
        }

        public string FullName => "Tailor Swift";
        public string Tweet
        {
            get { return _tweet; }
            set { Notify(value); }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }
    }
}

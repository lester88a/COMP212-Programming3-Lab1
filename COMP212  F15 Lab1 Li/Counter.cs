using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP212__F15_Lab1_Li
{
    class Counter
    {
        private int threshold; //警戒值
        private int totoal = 0;
        public Counter(int passedThreshold)
        {
            this.threshold = passedThreshold;
        }
        //Add method
        public void Add(int x)
        {
            totoal += x;
            if (totoal >= threshold)
            {
                //event object named args
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                //Threshold is the args object's proterty
                args.Threshold = threshold;
                //TimeReached is the args object's proterty
                args.TimeReached = DateTime.Now;
                OnThresholdReach(args);
            }

        }
        //OnThresholdReach method
        protected virtual void OnThresholdReach(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }

        }
        //Event 
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }
}

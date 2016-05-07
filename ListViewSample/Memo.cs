using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewSample
{
    class Memo
    {
        public string title { get; set; }
        public string content { get; set; }
        public DateTime memoDate { get; set; }

        public Memo(string title, string content, DateTime memoDate )
        {
            this.title = title;
            this.content = content;
            this.memoDate = memoDate;
        }

    }
}
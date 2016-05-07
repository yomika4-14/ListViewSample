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
    class MemoListAdapter : BaseAdapter<Memo>
    {

        Activity context;
        List<Memo> memoList;

        public MemoListAdapter (Activity context, List<Memo> memoList)
        {
            this.context = context;
            this.memoList = memoList;
        }

        public override Memo this[int position]
        {
            get
            {
                return memoList[position];
            }
        }

        public override int Count
        {
            get
            {
                return memoList == null ? 0 : memoList.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Memo memo = memoList[position];

            // Viewが再利用されていない場合は新しく作成
            var view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.Memo, null);


            // 表示内容の設定
            TextView tvTitle = view.FindViewById<TextView>(Resource.Id.title_text);
            TextView tvContent = view.FindViewById<TextView>(Resource.Id.content_text);
            TextView tvMemoDate = view.FindViewById<TextView>(Resource.Id.date_text);

            tvTitle.Text = memo.title;
            tvContent.Text = memo.content;
            tvMemoDate.Text = memo.memoDate.ToString("yyyy/MM/dd HH:mm:ss");
            
            return view;
        }
    }
}
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewSample
{
    [Activity(Label = "ListViewSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button btnAddMemo;
        Button btnDeleteAllMemo;
        ListView memoList;
        MemoListAdapter memoListAdapter;
        List<Memo> memos;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            // 画面要素取得
            btnAddMemo = FindViewById<Button>(Resource.Id.add_memo_btn);
            btnDeleteAllMemo = FindViewById<Button>(Resource.Id.delete_all_btn);
            memoList = FindViewById<ListView>(Resource.Id.memo_list);

            memos = new List<Memo>();
            
            // ボタンクリックイベント
            btnAddMemo.Click += (sender, e) =>
            {
                addMemos();
                memoListAdapter = new MemoListAdapter(this, memos);
                memoList.Adapter = memoListAdapter;
            };

            btnDeleteAllMemo.Click += (sender, e) =>
            {
                memos = new List<Memo>();
                memoListAdapter = new MemoListAdapter(this, memos);
                memoList.Adapter = memoListAdapter;
            };


        }

        private void addMemos()
        {
            int count = memos.Count;
            for(int i = 0; i < 5; i++)
            {
                int no = count + i;
                memos.Add(new Memo("タイトル" + no, "本文" + no, DateTime.Now));
            }
        }
    }
}


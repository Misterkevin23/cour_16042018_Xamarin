using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AstonEcole
{
    public class InstructorAdapter : BaseAdapter<Instructor>
    {
        List<Instructor> instructors;

        public InstructorAdapter(List<Instructor> instructors)
        {
            this.instructors = instructors;
        }

        public override Instructor this[int position]
        {
            get
            {
                return instructors[position];
            }
        }

        public override int Count
        {
            get
            {
                return instructors.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView; //cache de la view

            if (view == null)
            {
                var inflater = LayoutInflater.From(parent.Context);
                view = inflater.Inflate(Resource.Layout.CustomView, parent, false);


                var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var specialty = view.FindViewById<TextView>(Resource.Id.specialtyTextView);

                view.Tag = new ViewHolder() { Photo = photo, Name = name, Specialty = specialty }; //mise en cache
            }

            ViewHolder holder = (ViewHolder) view.Tag; //Caste de la view en viewholder

            Stream stream = parent.Context.Assets.Open(instructors[position].ImageUrl);
            Drawable drawable = Drawable.CreateFromStream(stream, null);
            holder.Photo.SetImageDrawable(drawable);

            holder.Name.Text = instructors[position].Name;
            holder.Specialty.Text = instructors[position].Specialty;

            return view;
        }
    }
}
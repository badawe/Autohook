using UnityEngine;

namespace BrunoMikoski.Framework.AutoHook
{
    public enum Context
    {
        Self = 0,
        Parent = 1,
        Child = 2
    }

    public enum Visibility
    {
        Default = 0,
        Visible = 1,
        Disabled = 2,
        Hidden = 4
    }

    public sealed class AutohookAttribute : PropertyAttribute
    {

        private readonly Context context = Context.Self;
        public Context Context { get { return context; } }
        private readonly Visibility visibility = Visibility.Hidden;
        public Visibility Visibility { get { return visibility; } }

        private bool ignoreSelf = true;
        public bool IgnoreSelf { get => ignoreSelf; }

        public AutohookAttribute()
        {
            context = Context.Self;
            visibility = Visibility.Default;
            ignoreSelf = true;
        }

        public AutohookAttribute(Context context) : this ()
        {
            this.context = context;
        }

        public AutohookAttribute(Visibility visibility): this ()
        {
            this.visibility = visibility;
        }

        public AutohookAttribute(Context context, Visibility visibility)
        {
            this.context = context;
            this.visibility = visibility;
        }

        public AutohookAttribute(Context context, bool ignoreSelf)
        {
            this.context = context;
            this.ignoreSelf = ignoreSelf;
        }
    }
}

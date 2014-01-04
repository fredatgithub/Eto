using Eto.Drawing;
using Eto.Forms;

namespace Eto.Test.Handlers
{
    class TabPageHandler : ThemedContainerHandler<Panel, TabPage>, ITabPage
    {
		public Padding Padding { get; set; }

		public Tab Tab { get; private set; }

		public Control Content { get { return Control != null ? Control.Content : null; } set { Control.Content = value; } }

		public Size MinimumSize { get { return Control.MinimumSize; } set { Control.MinimumSize = value; } }

        public TabPageHandler()
        {
			this.Tab = new Tab { Tag = this };
			this.Control = new Panel();
        }

		public string Text 
		{
			get { return Tab.Text; }
			set { Tab.Text = value; }
		}

#if DESKTOP
		public ContextMenu ContextMenu
		{
			get { return Control.ContextMenu; }
			set { Control.ContextMenu = value; } // TODO
		}
#endif

		public Image Image
		{
			get;
			set; // TODO
		}
    }
}

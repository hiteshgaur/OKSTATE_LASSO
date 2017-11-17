using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.ComponentModel;

namespace CampusResourceGuide
{
    [ContentProperty("Content")]
    public class ContentButton : ContentView
    {
       // public event EventHandler Clicked;
        public event EventHandler Pressed;
        protected Grid ContentGrid;
        protected ContentView ContentContainer;

        public new View Content
        {
            get { return ContentContainer.Content; }
            set
            {
                if (ContentGrid.Children.Contains(value))
                    return;

                ContentContainer.Content = value;
            }
        }

        public ContentButton()
        {
            ContentGrid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            ContentGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ContentGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            ContentContainer = new ContentView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            ContentGrid.Children.Add(ContentContainer);

            var button = new Button
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
               // BackgroundColor = Color.Orange,
                
            };

            //button.Clicked += (sender, e) => OnClicked();
            button.Clicked +=  OnPressed;
            
            //button.Clicked += await Navigation.PushAsync(new Page2Xaml());

            ContentGrid.Children.Add(button);

            base.Content = ContentGrid;

            this.PropertyChanged += OnElementPropertyChanged;
        }

        //private void ContentButton_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == nameof(IsEnabled))
        //    {
        //        UpdateVisualState();
        //    }
        //}

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == VisualElement.IsFocusedProperty.PropertyName)
            {
                //if (Control != null)
                //{
                //    Control.ShouldEndEditing =
                //    (UITextField textField) =>
                //    {
                       // Control.ResignFirstResponder();
                // first check button is clicked? from step 2
                //do coding here for button click fire event
                //return true;
                //    };
                //}
            }
            //base.OnElementPropertyChanged(sender, e);
        }

        private bool IsEntered { get; set; }
        private bool IsPressed { get; set; }
        //private void OnTouchEffectAction(object sender, object args)
        //{
        //    var touchArgs = args as TouchActionEventArgs;
        //    if (touchArgs == null) return;
        //    switch (touchArgs.Type)
        //    {
        //        case TouchActionType.Entered:
        //            IsEntered = true;
        //            break;
        //        case TouchActionType.Exited:
        //            IsEntered = false;
        //            break;
        //        case TouchActionType.Pressed:
        //            IsPressed = true;
        //            break;
        //        case TouchActionType.Released:
        //            IsPressed = false;
        //            if (IsEntered)
        //            {
        //                Pressed.SafeRaise(this);
        //            }
        //            break;
        //    }
        //    UpdateVisualState();
        //}

        //protected override void OnParentSet()
        //{
        //    base.OnParentSet();

        //    UpdateVisualState();
        //}

        //private void UpdateVisualState()
        //{
        //    if (IsEnabled)
        //    {
        //        if (IsPressed)
        //        {
        //            VisualStateManager.GoToState(this, "Pressed");
        //        }
        //        else if (IsEntered)
        //        {
        //            VisualStateManager.GoToState(this, "PointerOver");
        //        }
        //        else
        //        {
        //            VisualStateManager.GoToState(this, "Normal");
        //        }
        //    }
        //    else
        //    {
        //        VisualStateManager.GoToState(this, "Disabled");

        //    }
        //}

        public void OnPressed(object sender, EventArgs ea)
        {
          //  if (Pressed != null)
                Pressed(this, ea);
        }
    }

    public class TouchActionEventArgs : EventArgs
    {
        public TouchActionEventArgs(long id, TouchActionType type, Point location, bool isInContact)
        {
            Id = id;
            Type = type;
            Location = location;
            IsInContact = isInContact;
        }

        public long Id { private set; get; }

        public TouchActionType Type { private set; get; }

        public Point Location { private set; get; }

        public bool IsInContact { private set; get; }
    }
    public delegate void TouchActionEventHandler(object sender, TouchActionEventArgs args);
    public enum TouchActionType
    {
        Entered,
        Pressed,
        Moved,
        Released,
        Exited,
        Cancelled
    }
}

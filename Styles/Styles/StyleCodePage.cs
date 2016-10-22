﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Styles
{
    public class StyleCodePage : ContentPage
    {
        public StyleCodePage()
        {
            Resources = new ResourceDictionary
            {
                { "buttonStyle", new Style(typeof(Button))
                    {
                        Setters =
                        {
                            new Setter
                            {
                                Property = View.HorizontalOptionsProperty,
                                Value = LayoutOptions.Center
                            },
                            new Setter
                            {
                                Property = View.VerticalOptionsProperty,
                                Value = LayoutOptions.CenterAndExpand
                            },
                            new Setter
                            {
                                Property = Button.BorderWidthProperty,
                                Value = 3
                            },
                            new Setter
                            {
                                Property = Button.TextColorProperty,
                                Value = Color.Red
                            },
                            new Setter
                            {
                                Property = Button.FontSizeProperty,
                                Value = Device.GetNamedSize(NamedSize.Large, typeof(Button))
                            },
                            new Setter
                            {
                                Property = VisualElement.BackgroundColorProperty,
                                Value = Device.OnPlatform(Color.Default,
                                                          Color.FromRgb(0x40, 0x40, 0x40),
                                                          Color.Default)
                            },
                            new Setter
                            {
                                Property = Button.BorderColorProperty,
                                Value = Device.OnPlatform(Color.Default,
                                                          Color.White,
                                                          Color.Black)
                            }
                        }
                    }
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    new Button
                    {
                        Text = " Carpe diem ",
                        Style = (Style)Resources["buttonStyle"]
                    },
                    new Button
                    {
                        Text = " Sapere aude ",
                        Style = (Style)Resources["buttonStyle"]
                    },
                    new Button
                    {
                        Text = " Discere faciendo ",
                        Style = (Style)Resources["buttonStyle"]
                    }
                }
            };
        }
    }
}

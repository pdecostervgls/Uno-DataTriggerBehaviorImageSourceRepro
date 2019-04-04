// <autogenerated />
// Xaml Source Generation is using the System Xaml Parser
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using DTBImageSource.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#elif NET46
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace DTBImageSource
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 1:2)
			Content = 			new global::Windows.UI.Xaml.Controls.StackPanel
			{
				Padding = new global::Windows.UI.Xaml.Thickness(12),
				// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 12:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.ToggleSwitch
					{
						Name = "toggle",
						Header = @"Toggled?",
						// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 13:10)
					}
					.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler0)(c0 => 
					{
						nameScope.RegisterName("toggle", c0);
						this.toggle = c0;
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.TextBlock
					{
						Name = "tb",
						Text = "Empty",
						// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 14:10)
					}
					.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler1)(c1 => 
					{
						nameScope.RegisterName("tb", c1);
						this.tb = c1;
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.Image
					{
						Name = "image",
						Stretch = Windows.UI.Xaml.Media.Stretch.None,
						HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left,
						// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 15:10)
					}
					.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler2)(c2 => 
					{
						nameScope.RegisterName("image", c2);
						this.image = c2;
						var c2_collection_0 = Microsoft.Xaml.Interactivity.Interaction.GetBehaviors(c2);
						c2_collection_0.Add(						new global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior
						{
							Value = @"false",
							// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 17:18)
							Actions = 
							{
								new global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction
								{
									PropertyName = @"Source",
									Value = @"/Assets/checkbox_unchecked.png",
									// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 18:22)
								}
								.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler3)(c3 => 
								{
									c3.SetBinding(global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction.TargetObjectProperty, new Windows.UI.Xaml.Data.Binding{ ElementName = _imageSubject });
																	}
								))
								,
								new global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction
								{
									PropertyName = @"Text",
									Value = @"Unchecked",
									// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 19:22)
								}
								.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler3)(c4 => 
								{
									c4.SetBinding(global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction.TargetObjectProperty, new Windows.UI.Xaml.Data.Binding{ ElementName = _tbSubject });
																	}
								))
								,
							}
						}
						.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler4)(c5 => 
						{
							c5.SetBinding(global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior.BindingProperty, new Windows.UI.Xaml.Data.Binding{ ElementName = _toggleSubject, Path = @"IsOn" });
													}
						))
						);
						c2_collection_0.Add(						new global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior
						{
							Value = @"true",
							// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 21:18)
							Actions = 
							{
								new global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction
								{
									PropertyName = @"Source",
									Value = @"/Assets/checkbox_checked.png",
									// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 22:22)
								}
								.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler3)(c6 => 
								{
									c6.SetBinding(global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction.TargetObjectProperty, new Windows.UI.Xaml.Data.Binding{ ElementName = _imageSubject });
																	}
								))
								,
								new global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction
								{
									PropertyName = @"Text",
									Value = @"Checked",
									// Source ..\..\..\..\..\..\..\DTBImageSource.Shared\MainPage.xaml (Line 23:22)
								}
								.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler3)(c7 => 
								{
									c7.SetBinding(global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction.TargetObjectProperty, new Windows.UI.Xaml.Data.Binding{ ElementName = _tbSubject });
																	}
								))
								,
							}
						}
						.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler4)(c8 => 
						{
							c8.SetBinding(global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior.BindingProperty, new Windows.UI.Xaml.Data.Binding{ ElementName = _toggleSubject, Path = @"IsOn" });
													}
						))
						);
					}
					))
					,
				}
			}
			.MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply((MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions.XamlApplyHandler5)(c9 => 
			{
				c9.Background = ((Windows.UI.Xaml.Media.Brush)global::Uno.UI.GlobalStaticResources.ApplicationPageBackgroundThemeBrush);
				
			}
			))
			;
			
			this
			.Apply((c10 => 
			{
				// Source C:\Users\pdeco\source\repos\UnoRepros\DTBImageSource\DTBImageSource\DTBImageSource.Shared\MainPage.xaml (Line 1:2)
			}
			))
			.Apply((c11 => 
			{
				// Class DTBImageSource.MainPage
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _toggleSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.ToggleSwitch toggle
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ToggleSwitch)_toggleSubject.ElementInstance;
			}
			set
			{
				_toggleSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _tbSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.TextBlock tb
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_tbSubject.ElementInstance;
			}
			set
			{
				_tbSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _imageSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Image image
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Image)_imageSubject.ElementInstance;
			}
			set
			{
				_imageSubject.ElementInstance = value;
			}
		}
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace DTBImageSource.Droid
{
	static class MainPage_358c5840d0f8bbfbb95a49e6ba26cb7aXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ToggleSwitch instance);
		public static global::Windows.UI.Xaml.Controls.ToggleSwitch MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply(this global::Windows.UI.Xaml.Controls.ToggleSwitch instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.Image instance);
		public static global::Windows.UI.Xaml.Controls.Image MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply(this global::Windows.UI.Xaml.Controls.Image instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction instance);
		public static global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply(this global::Microsoft.Xaml.Interactions.Core.ChangePropertyAction instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior instance);
		public static global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply(this global::Microsoft.Xaml.Interactions.Core.DataTriggerBehavior instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel MainPage_358c5840d0f8bbfbb95a49e6ba26cb7a_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
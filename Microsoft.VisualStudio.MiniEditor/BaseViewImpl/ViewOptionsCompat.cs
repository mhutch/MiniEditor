//
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License. See License.txt in the project root for license information.
//

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor.OptionsExtensionMethods;
using Microsoft.VisualStudio.Utilities;


namespace Microsoft.VisualStudio.Text.Editor
{
	// EditorOperations in vs-editor-api references an option called ShouldMoveCaretOnSelectAll, but it seems to have been renamed
	// so this just maps it to the new method
	static class OptionsCompat
	{
		public static bool ShouldMoveCaretOnSelectAll (this IEditorOptions options) => options.ShouldMoveCaretToEndOnSelectAll ();
	}

	/// <summary>
	/// Defines common <see cref="ITextView"/> options.
	/// </summary>
	public static class DefaultWpfViewOptions
	{
		#region Option identifiers
		/// <summary>
		/// Determines whether to enable the highlight current line adornment.
		/// </summary>
		public static readonly EditorOptionKey<bool> EnableHighlightCurrentLineId = new EditorOptionKey<bool> (EnableHighlightCurrentLineName);
		public const string EnableHighlightCurrentLineName = "Adornments/HighlightCurrentLine/Enable";

		/// <summary>
		/// Determines whether to enable the highlight current line adornment.
		/// </summary>
		public static readonly EditorOptionKey<bool> EnableSimpleGraphicsId = new EditorOptionKey<bool> (EnableSimpleGraphicsName);
		public const string EnableSimpleGraphicsName = "Graphics/Simple/Enable";

		/// <summary>
		/// Determines whether the opacity of text markers and selection is reduced in high contrast mode.
		/// </summary>
		public static readonly EditorOptionKey<bool> UseReducedOpacityForHighContrastOptionId = new EditorOptionKey<bool> (UseReducedOpacityForHighContrastOptionName);
		public const string UseReducedOpacityForHighContrastOptionName = "UseReducedOpacityForHighContrast";

		/// <summary>
		/// Determines whether to enable mouse wheel zooming
		/// </summary>
		public static readonly EditorOptionKey<bool> EnableMouseWheelZoomId = new EditorOptionKey<bool> (EnableMouseWheelZoomName);
		public const string EnableMouseWheelZoomName = "TextView/MouseWheelZoom";

		/// <summary>
		/// Determines the appearance category of a view, which selects a ClassificationFormatMap and EditorFormatMap.
		/// </summary>
		public static readonly EditorOptionKey<string> AppearanceCategory = new EditorOptionKey<string> (AppearanceCategoryName);
		public const string AppearanceCategoryName = "Appearance/Category";

		/// <summary>
		/// Determines the view zoom level.
		/// </summary>
		public static readonly EditorOptionKey<double> ZoomLevelId = new EditorOptionKey<double> (ZoomLevelName);
		public const string ZoomLevelName = "TextView/ZoomLevel";

		/// <summary>
		/// Determines the minimum view zoom level.
		/// </summary>
		public static readonly EditorOptionKey<double> MinZoomLevelId = new EditorOptionKey<double> (MinZoomLevelName);
		public const string MinZoomLevelName = "TextView/MinZoomLevel";

		/// <summary>
		/// Determines the maximum view zoom level.
		/// </summary>
		public static readonly EditorOptionKey<double> MaxZoomLevelId = new EditorOptionKey<double> (MaxZoomLevelName);
		public const string MaxZoomLevelName = "TextView/MaxZoomLevel";

		/// <summary>
		/// Determines whether to enable mouse click + modifier keypress for go to definition.
		/// </summary>
		public const string ClickGoToDefEnabledName = "TextView/ClickGoToDefEnabled";
		public static readonly EditorOptionKey<bool> ClickGoToDefEnabledId = new EditorOptionKey<bool> (ClickGoToDefEnabledName);

		/// <summary>
		/// Determines whether to open definition target in Peek view for mouse click + modifier keypress.
		/// </summary>
		public const string ClickGoToDefOpensPeekName = "TextView/ClickGoToDefOpensPeek";
		public static readonly EditorOptionKey<bool> ClickGoToDefOpensPeekId = new EditorOptionKey<bool> (ClickGoToDefOpensPeekName);
		#endregion
	}

	/// <summary>
	/// Represents the option to highlight the current line.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.EnableHighlightCurrentLineName)]
	public sealed class HighlightCurrentLineOption : EditorOptionDefinition<bool>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override bool Default { get { return true; } }

		/// <summary>
		/// Gets the key for the highlight current line option.
		/// </summary>
		public override EditorOptionKey<bool> Key { get { return DefaultWpfViewOptions.EnableHighlightCurrentLineId; } }
	}

	/// <summary>
	/// Represents the option to draw a selection gradient as opposed to a solid color selection.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.EnableSimpleGraphicsName)]
	public sealed class SimpleGraphicsOption : EditorOptionDefinition<bool>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override bool Default { get { return false; } }

		/// <summary>
		/// Gets the key for the simple graphics option.
		/// </summary>
		public override EditorOptionKey<bool> Key { get { return DefaultWpfViewOptions.EnableSimpleGraphicsId; } }
	}

	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.UseReducedOpacityForHighContrastOptionName)]
	public sealed class UseReducedOpacityForHighContrastOption : EditorOptionDefinition<bool>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override bool Default { get { return false; } }

		/// <summary>
		/// Gets the key for the use reduced opacity option.
		/// </summary>
		public override EditorOptionKey<bool> Key { get { return DefaultWpfViewOptions.UseReducedOpacityForHighContrastOptionId; } }
	}

	/// <summary>
	/// Defines the option to enable the mouse wheel zoom
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.EnableMouseWheelZoomName)]
	public sealed class MouseWheelZoomEnabled : EditorOptionDefinition<bool>
	{
		/// <summary>
		/// Gets the default value, which is <c>true</c>.
		/// </summary>
		public override bool Default { get { return true; } }

		/// <summary>
		/// Gets the wpf text view  value.
		/// </summary>
		public override EditorOptionKey<bool> Key { get { return DefaultWpfViewOptions.EnableMouseWheelZoomId; } }
	}

	/// <summary>
	/// Defines the appearance category.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.AppearanceCategoryName)]
	public sealed class AppearanceCategoryOption : EditorOptionDefinition<string>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override string Default { get { return "text"; } }

		/// <summary>
		/// Gets the key for the appearance category option.
		/// </summary>
		public override EditorOptionKey<string> Key { get { return DefaultWpfViewOptions.AppearanceCategory; } }
	}

	/// <summary>
	/// Defines the zoomlevel.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.ZoomLevelName)]
	public sealed class ZoomLevel : EditorOptionDefinition<double>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override double Default { get { return (int)ZoomConstants.DefaultZoom; } }

		/// <summary>
		/// Gets the key for the text view zoom level.
		/// </summary>
		public override EditorOptionKey<double> Key { get { return DefaultWpfViewOptions.ZoomLevelId; } }
	}

	/// <summary>
	/// Defines the minimum zoomlevel.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.MinZoomLevelName)]
	public sealed class MinZoomLevel : EditorOptionDefinition<double>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override double Default => ZoomConstants.MinZoom;

		/// <summary>
		/// Gets the key for the text view zoom level.
		/// </summary>
		public override EditorOptionKey<double> Key => DefaultWpfViewOptions.MinZoomLevelId;
	}

	/// <summary>
	/// Defines the maximum zoomlevel.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.MaxZoomLevelName)]
	public sealed class MaxZoomLevel : EditorOptionDefinition<double>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override double Default => ZoomConstants.MaxZoom;

		/// <summary>
		/// Gets the key for the text view zoom level.
		/// </summary>
		public override EditorOptionKey<double> Key => DefaultWpfViewOptions.MaxZoomLevelId;
	}

	/// <summary>
	/// Determines whether to enable mouse click + modifier keypress for go to definition.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.ClickGoToDefEnabledName)]
	public sealed class ClickGotoDefEnabledOption : EditorOptionDefinition<bool>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override bool Default => true;

		/// <summary>
		/// Gets the key for the option.
		/// </summary>
		public override EditorOptionKey<bool> Key => DefaultWpfViewOptions.ClickGoToDefEnabledId;
	}

	/// <summary>
	/// Determines whether to open definition target in Peek view for mouse click + modifier keypress.
	/// </summary>
	[Export (typeof (EditorOptionDefinition))]
	[Name (DefaultWpfViewOptions.ClickGoToDefOpensPeekName)]
	public sealed class ClickGotoDefOpensPeekOption : EditorOptionDefinition<bool>
	{
		/// <summary>
		/// Gets the default value.
		/// </summary>
		public override bool Default => false;

		/// <summary>
		/// Gets the key for the option.
		/// </summary>
		public override EditorOptionKey<bool> Key => DefaultWpfViewOptions.ClickGoToDefOpensPeekId;
	}
}
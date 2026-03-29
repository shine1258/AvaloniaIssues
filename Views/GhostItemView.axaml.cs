using System.Linq;
using Avalonia.Controls;

namespace AvaloniaIssues.Views;

public partial class GhostItemView : UserControl
{
    public GhostItemView() => InitializeComponent();

    public Item[] Items { get; } =
        Enumerable.Range(1, 20).Select(i => new Item(i, i % 2 == 1)).ToArray();

    public record Item(int Index, bool ShowMore);
}

using LessenDependency.Actions;
using LessenDependency;

var sweeper = new Sweepable();
var gallery = new ArtExhibit();

var wallart = new Carpet(sweeper, gallery);

foreach (var action in wallart.actions)
{
    action.Action();
}

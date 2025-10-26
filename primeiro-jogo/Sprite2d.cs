using Godot;
public partial class Player : Node2D
{
	public override void _Process(double delta)
	{
		Position += new Vector2(100 * (float)delta, 0); // move pra direita
	}
}

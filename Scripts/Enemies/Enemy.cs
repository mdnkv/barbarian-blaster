using Godot;
using System;

public partial class Enemy : PathFollow3D
{

    [Export] private float speed = 2.5f;

    public override void _Process(double delta)
    {
        Progress = Progress + ((float) delta * speed);
    }
}

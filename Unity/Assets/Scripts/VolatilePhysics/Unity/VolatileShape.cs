﻿using System;
using System.Collections.Generic;

using UnityEngine;

using Volatile;

public abstract class VolatileShape : MonoBehaviour
{
  [SerializeField]
  protected float density = 1.0f;

  public abstract Shape Shape { get; }

  public abstract Shape PrepareShape(VolatileBody body);

  public abstract void DrawShapeInGame();
  public abstract void DrawShapeInEditor();

  public abstract Vector2 ComputeTrueCenterOfMass();

  protected Vector2 GetBodyLocalPoint(VolatileBody body, Vector2 point)
  {
    return
      body.transform.InverseTransformPoint(
        this.transform.TransformPoint(point));
  }
}

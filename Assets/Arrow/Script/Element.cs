﻿using System.Collections;
using System.Collections.Generic;
using RoadCreator;
using UnityEngine;

namespace Arrow.Script
{
	public abstract class Element : MonoBehaviour
	{
		[SerializeField] float position;
		public float Position
		{
			get
			{
				return groupElement == null ? position : position + groupElement.Position;
			}
		}
		public float LocalPosition => position;
		public void SetPosition(float p)
		{
			position = p;
		}
		public abstract void Init();
		public abstract void OnHit(GameObject collider);
		protected GroupPath groupPath;
		protected GroupElement groupElement;

		float lastPosition = 0.001f;
		float tmpPos;
		public void UpdatePosition()
		{
			groupElement = transform.parent != null ? transform.parent.GetComponent<GroupElement>() : null;
			if(groupElement == null)
			{
				groupPath = GetComponentInParent<GroupPath>();
			} else
			{
				groupPath = transform.parent != null ? transform.parent.GetComponentInParent<GroupPath>() : null;
			}

			if (groupPath == null)
			{
				return;
			}

			if (!groupPath.Initialized)
			{
				return;
			}


			if (lastPosition == position)
			{
				return;
			}

			if (groupElement != null)
			{
				//Debug.LogError(gameObject.gameObject + ", " + groupElement.name + ", " + Position + "," + groupPath.Length);
			}
			
			float tmpPos = Mathf.Clamp01(Position / groupPath.Length);
			transform.position = groupPath.GetPointAtTime(tmpPos);
			transform.rotation = groupPath.GetDirectionAtTime(tmpPos);
			lastPosition = position;
		}
		protected virtual void ManualValidate()
		{

		}

#if UNITY_EDITOR
		private void OnValidate()
		{
			if (!isActiveAndEnabled)
			{
				return;
			}

			if (Application.isPlaying)
			{
				return;
			}
			UpdatePosition();
			ManualValidate();
		}
#endif
	}

	[System.Serializable]
	public struct ElementData
	{
		public float position;
		public Element element;
	}
}
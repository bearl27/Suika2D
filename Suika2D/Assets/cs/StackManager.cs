using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public StackManager parentStackManager;
    public List<StackManager> childStackManagers = new List<StackManager>();
    private Rigidbody rb;
    public int totalStackCount { get; private set; } = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        StackManager other = collision.gameObject.GetComponent<StackManager>();
        if (other != null)
        {
            // 親子関係を設定
            parentStackManager = other;
            other.childStackManagers.Add(this);
            UpdateStackCount();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        StackManager other = collision.gameObject.GetComponent<StackManager>();
        if (other != null && parentStackManager == other)
        {
            // 親子関係を解除
            parentStackManager.childStackManagers.Remove(this);
            parentStackManager = null;
            UpdateStackCount();
        }
    }

    void UpdateStackCount()
    {
        totalStackCount = 1; // 自分自身
        if (parentStackManager != null)
        {
            totalStackCount += parentStackManager.totalStackCount;
        }
        foreach (var child in childStackManagers)
        {
            child.UpdateStackCount(); // 子に対して再帰的に更新
        }

        CheckStackLimit();
    }

    private void CheckStackLimit()
    {
        if (totalStackCount >= 5)
        {
            Debug.Log("Stack Limit");
            rb.mass *= 2; // 質量を増やし、ズレやすくする
        }
    }
}
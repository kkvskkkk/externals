/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiMaterialVector : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IList<aiMaterial>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMaterialVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiMaterialVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMaterialVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiMaterialVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiMaterialVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (aiMaterial element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public aiMaterial this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(aiMaterial[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(aiMaterial[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, aiMaterial[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<aiMaterial> System.Collections.Generic.IEnumerable<aiMaterial>.GetEnumerator() {
    return new aiMaterialVectorEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new aiMaterialVectorEnumerator(this);
  }

  public aiMaterialVectorEnumerator GetEnumerator() {
    return new aiMaterialVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class aiMaterialVectorEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<aiMaterial>
#endif
  {
    private aiMaterialVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public aiMaterialVectorEnumerator(aiMaterialVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public aiMaterial Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (aiMaterial)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    AssimpPINVOKE.aiMaterialVector_Clear(swigCPtr);
  }

  public void Add(aiMaterial x) {
    AssimpPINVOKE.aiMaterialVector_Add(swigCPtr, aiMaterial.getCPtr(x));
  }

  private uint size() {
    uint ret = AssimpPINVOKE.aiMaterialVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = AssimpPINVOKE.aiMaterialVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    AssimpPINVOKE.aiMaterialVector_reserve(swigCPtr, n);
  }

  public aiMaterialVector() : this(AssimpPINVOKE.new_aiMaterialVector__SWIG_0(), true) {
  }

  public aiMaterialVector(aiMaterialVector other) : this(AssimpPINVOKE.new_aiMaterialVector__SWIG_1(aiMaterialVector.getCPtr(other)), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiMaterialVector(int capacity) : this(AssimpPINVOKE.new_aiMaterialVector__SWIG_2(capacity), true) {
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  private aiMaterial getitemcopy(int index) {
    IntPtr cPtr = AssimpPINVOKE.aiMaterialVector_getitemcopy(swigCPtr, index);
    aiMaterial ret = (cPtr == IntPtr.Zero) ? null : new aiMaterial(cPtr, false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private aiMaterial getitem(int index) {
    IntPtr cPtr = AssimpPINVOKE.aiMaterialVector_getitem(swigCPtr, index);
    aiMaterial ret = (cPtr == IntPtr.Zero) ? null : new aiMaterial(cPtr, false);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, aiMaterial val) {
    AssimpPINVOKE.aiMaterialVector_setitem(swigCPtr, index, aiMaterial.getCPtr(val));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(aiMaterialVector values) {
    AssimpPINVOKE.aiMaterialVector_AddRange(swigCPtr, aiMaterialVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiMaterialVector GetRange(int index, int count) {
    IntPtr cPtr = AssimpPINVOKE.aiMaterialVector_GetRange(swigCPtr, index, count);
    aiMaterialVector ret = (cPtr == IntPtr.Zero) ? null : new aiMaterialVector(cPtr, true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, aiMaterial x) {
    AssimpPINVOKE.aiMaterialVector_Insert(swigCPtr, index, aiMaterial.getCPtr(x));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, aiMaterialVector values) {
    AssimpPINVOKE.aiMaterialVector_InsertRange(swigCPtr, index, aiMaterialVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    AssimpPINVOKE.aiMaterialVector_RemoveAt(swigCPtr, index);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    AssimpPINVOKE.aiMaterialVector_RemoveRange(swigCPtr, index, count);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static aiMaterialVector Repeat(aiMaterial value, int count) {
    IntPtr cPtr = AssimpPINVOKE.aiMaterialVector_Repeat(aiMaterial.getCPtr(value), count);
    aiMaterialVector ret = (cPtr == IntPtr.Zero) ? null : new aiMaterialVector(cPtr, true);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    AssimpPINVOKE.aiMaterialVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    AssimpPINVOKE.aiMaterialVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, aiMaterialVector values) {
    AssimpPINVOKE.aiMaterialVector_SetRange(swigCPtr, index, aiMaterialVector.getCPtr(values));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(aiMaterial value) {
    bool ret = AssimpPINVOKE.aiMaterialVector_Contains(swigCPtr, aiMaterial.getCPtr(value));
    return ret;
  }

  public int IndexOf(aiMaterial value) {
    int ret = AssimpPINVOKE.aiMaterialVector_IndexOf(swigCPtr, aiMaterial.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(aiMaterial value) {
    int ret = AssimpPINVOKE.aiMaterialVector_LastIndexOf(swigCPtr, aiMaterial.getCPtr(value));
    return ret;
  }

  public bool Remove(aiMaterial value) {
    bool ret = AssimpPINVOKE.aiMaterialVector_Remove(swigCPtr, aiMaterial.getCPtr(value));
    return ret;
  }

}

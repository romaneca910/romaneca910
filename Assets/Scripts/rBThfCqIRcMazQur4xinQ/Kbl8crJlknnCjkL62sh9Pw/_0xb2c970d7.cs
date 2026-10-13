using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xb2c970d7 : MonoBehaviour
{
    private Vector3 _0xf29a46c3 { get; set; }

    private float _0x3de7b05c = 1;
    private Vector3 _0x5be6694d { get; set; }
    private float _0x6d800e94 { get; set; }
    private Vector3 _0x1bb66649 { get; set; }

    private void _0xd670e635()
    {
        float _0xddb870f3, _0x6b973a35, _0x7b8b91aa, _0x864b4d8c;
        if (this._0xdc765568 == _0x99a7fca8.Landscape)
            this._0x1c8673a3.orthographicSize = 1f / this._0x1c8673a3.aspect * this._0x3de7b05c / 2f;
        else
            this._0x1c8673a3.orthographicSize = this._0x3de7b05c / 2f;
        this._0x6d800e94 = 2f * this._0x1c8673a3.orthographicSize;
        this._0x5cf1d66f = this._0x6d800e94 * this._0x1c8673a3.aspect;
        float _0xfb9acea2 = this._0x1c8673a3.transform.position.x;
        float _0x74661cde = this._0x1c8673a3.transform.position.y;
        _0xddb870f3 = _0xfb9acea2 - this._0x5cf1d66f / 2;
        _0x6b973a35 = _0xfb9acea2 + this._0x5cf1d66f / 2;
        _0x7b8b91aa = _0x74661cde + this._0x6d800e94 / 2;
        _0x864b4d8c = _0x74661cde - this._0x6d800e94 / 2;
        this._0x5be6694d = new Vector3(_0xddb870f3, _0x864b4d8c, 0);
        this._0xf29a46c3 = new Vector3(_0xfb9acea2, _0x864b4d8c, 0);
        this._0xc598529c = new Vector3(_0x6b973a35, _0x864b4d8c, 0);
        this._0xdafcb49e = new Vector3(_0xddb870f3, _0x74661cde, 0);
        this._0x09ee5106 = new Vector3(_0xfb9acea2, _0x74661cde, 0);
        this._0x1bb66649 = new Vector3(_0x6b973a35, _0x74661cde, 0);
        this._0xcfe5db9c = new Vector3(_0xddb870f3, _0x7b8b91aa, 0);
        this._0xcb2531e5 = new Vector3(_0xfb9acea2, _0x7b8b91aa, 0);
        this._0x36353884 = new Vector3(_0x6b973a35, _0x7b8b91aa, 0);
    }

    private Vector3 _0xc598529c { get; set; }

    private void Awake()
    {
        this._0x1c8673a3 = this.GetComponent<Camera>();
        _0xc04b3b65 = this;
        this._0xd670e635();
    }

    private Vector3 _0xdafcb49e { get; set; }
    private Vector3 _0xcfe5db9c { get; set; }
    private Vector3 _0xcb2531e5 { get; set; }

    public enum _0x99a7fca8
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x09ee5106 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x6219f6cc;
        Matrix4x4 _0x1838825b = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x1c8673a3.orthographic)
        {
            float _0x997eddc8 = this._0x1c8673a3.farClipPlane - this._0x1c8673a3.nearClipPlane;
            float _0x9ee27097 = (this._0x1c8673a3.farClipPlane + this._0x1c8673a3.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x9ee27097), new Vector3(this._0x1c8673a3.orthographicSize * 2 * this._0x1c8673a3.aspect, this._0x1c8673a3.orthographicSize * 2, _0x997eddc8));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x1c8673a3.fieldOfView, this._0x1c8673a3.farClipPlane, this._0x1c8673a3.nearClipPlane, this._0x1c8673a3.aspect);
        }

        Gizmos.matrix = _0x1838825b;
    }

    private Vector3 _0x36353884 { get; set; }

    private new Camera _0x1c8673a3;
    private static _0xb2c970d7 _0xc04b3b65;
    private _0x99a7fca8 _0xdc765568 = _0x99a7fca8.Portrait;
    //public bool executeInUpdate;
    private float _0x5cf1d66f { get; set; }

    private Color _0x6219f6cc = Color.white;
}
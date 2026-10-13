using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Three settings, and every one of them changes something you can see in the frame.
// There is no sound in this game, so there is no volume slider and no speaker icon:
// a control that changes nothing is a dead element (rule C.20).
public sealed class _0xaafb68af : MonoBehaviour
{
    [SerializeField]
    private _0xfc9e8c39 _progress;
    public void _0x09f2eccf()
    {
        this._0x2ec6b8f1 = false;
        this._0x9a9e3ee9();
        if (this._gate != null)
            this._gate.Show(0.22f);
    }

    private void _0xaf87e36d()
    {
        if (this._progress == null)
            return;
        this._progress._0x4678db12 = !this._progress._0x4678db12;
        this._progress._0x760b43bf();
        this._0x9a9e3ee9();
    }

    private void _0x2eaa9039()
    {
        if (this._progress == null)
            return;
        this._progress._0x64269987 = !this._progress._0x64269987;
        this._progress._0x760b43bf();
        this._0x9a9e3ee9();
    }

    [SerializeField]
    private Button _close;
    [SerializeField]
    private TMP_Text _resetLabel;
    [SerializeField]
    private TMP_Text _boostBadgeA;
    [SerializeField]
    private TMP_Text _title;
    public void _0x2f4e3bb0()
    {
        if (this._gate != null)
            this._gate._0x96c1aad5();
    }

    [SerializeField]
    private _0x6325e58b _map;
    [SerializeField]
    private TMP_Text _motionLabel;
    [SerializeField]
    private Image _boostPreviewB;
    private bool _0x2ec6b8f1;
    // Two steps, because wiping a garden by accident is a bad afternoon.
    private void _0xe3fa2ca2()
    {
        if (this._progress == null)
            return;
        if (!this._0x2ec6b8f1)
        {
            this._0x2ec6b8f1 = true;
            this._0x98de4553 = Time.unscaledTime;
            this._0x9a9e3ee9();
            return;
        }

        this._0x2ec6b8f1 = false;
        this._progress._0xfef572b8();
        this._0x9a9e3ee9();
        if (this._map != null)
            this._map._0xad04fa9a();
    }

    private void OnDestroy()
    {
        if (this._motionPreview != null)
            DOTween.Kill(this._motionPreview);
    }

    [SerializeField]
    private Button _motionButton;
    private float _0x98de4553;
    [SerializeField]
    private TMP_Text _motionState;
    [SerializeField]
    private Button _boostButton;
    [SerializeField]
    private TMP_Text _boostBadgeB;
    [SerializeField]
    private Button _resetButton;
    // Every row shows its own result in the frame: the preview tiles gain their boosted
    // tint and shape badge, the preview petal changes speed, the reset button changes
    // its own wording and colour.
    private void _0x9a9e3ee9()
    {
        if (this._progress == null)
            return;
        bool _0x89a1aec7 = this._progress._0x4678db12;
        if (this._boostState != null)
            this._boostState.text = _0x89a1aec7 ? _0x995ce124._0x8e148fcd(new byte[2] { 29, 28 }, 82) : _0x995ce124._0x8e148fcd(new byte[3] { 20, 29, 29 }, 91);
        if (this._boostPreviewA != null)
            this._boostPreviewA.color = _0x89a1aec7 ? _0xcc07f46d.Species[1] : _0xcc07f46d.Fade(_0xcc07f46d.Species[1], 0.35f);
        if (this._boostPreviewB != null)
            this._boostPreviewB.color = _0x89a1aec7 ? _0xcc07f46d.Species[3] : _0xcc07f46d.Fade(_0xcc07f46d.Species[3], 0.35f);
        if (this._boostBadgeA != null)
            this._boostBadgeA.gameObject.SetActive(_0x89a1aec7);
        if (this._boostBadgeB != null)
            this._boostBadgeB.gameObject.SetActive(_0x89a1aec7);
        bool _0xeaaabcfb = this._progress._0x64269987;
        if (this._motionState != null)
            this._motionState.text = _0xeaaabcfb ? _0x995ce124._0x8e148fcd(new byte[2] { 163, 162 }, 236) : _0x995ce124._0x8e148fcd(new byte[3] { 144, 153, 153 }, 223);
        if (this._motionPreview != null)
        {
            DOTween.Kill(this._motionPreview);
            this._motionPreview.localScale = Vector3.one;
            float _0x65aa5b87 = _0xeaaabcfb ? 2.4f : 0.8f;
            this._motionPreview.DOScale(1.18f, _0x65aa5b87).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._motionPreview.gameObject);
        }

        if (this._resetLabel != null)
            this._resetLabel.text = this._0x2ec6b8f1 ? _0x995ce124._0x8e148fcd(new byte[20] { 217, 204, 221, 173, 204, 202, 204, 196, 195, 173, 217, 194, 173, 206, 194, 195, 203, 196, 223, 192 }, 141) : _0x995ce124._0x8e148fcd(new byte[12] { 86, 65, 87, 65, 80, 36, 67, 69, 86, 64, 65, 74 }, 4);
        if (this._resetPlate != null)
            this._resetPlate.color = this._0x2ec6b8f1 ? _0xcc07f46d.Rose : _0xcc07f46d.Fade(_0xcc07f46d.SurfaceDeep, 0.9f);
    }

    [SerializeField]
    private Image _resetPlate;
    private void Update()
    {
        if (!this._0x2ec6b8f1)
            return;
        if (Time.unscaledTime - this._0x98de4553 < 2.5f)
            return;
        this._0x2ec6b8f1 = false;
        this._0x9a9e3ee9();
    }

    private void Start()
    {
        _0x978b485d.Shape(this._title, 40f, 56f);
        _0x978b485d.Shape(this._boostLabel, 32f, 42f);
        _0x978b485d.Shape(this._motionLabel, 32f, 42f);
        _0x978b485d.Shape(this._resetLabel, 30f, 42f);
        _0x978b485d.Shape(this._boostState, 26f, 34f);
        _0x978b485d.Shape(this._motionState, 26f, 34f);
        _0x978b485d.Shape(this._boostBadgeA, 24f, 30f);
        _0x978b485d.Shape(this._boostBadgeB, 24f, 30f);
        _0x978b485d.ApplyOutline(this._title, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._boostLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._motionLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._resetLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._boostState, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._motionState, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._boostBadgeA, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._boostBadgeB, _0xcc07f46d.Ink);
        if (this._title != null)
            this._title.text = _0x995ce124._0x8e148fcd(new byte[15] { 154, 156, 143, 153, 152, 147, 253, 142, 152, 137, 137, 148, 147, 154, 142 }, 221);
        if (this._boostLabel != null)
            this._boostLabel.text = _0x995ce124._0x8e148fcd(new byte[11] { 212, 216, 219, 216, 197, 183, 213, 216, 216, 196, 195 }, 151);
        if (this._motionLabel != null)
            this._motionLabel.text = _0x995ce124._0x8e148fcd(new byte[13] { 153, 142, 143, 158, 136, 142, 235, 134, 132, 159, 130, 132, 133 }, 203);
        if (this._boostBadgeA != null)
            this._boostBadgeA.text = _0x995ce124._0x8e148fcd(new byte[1] { 216 }, 242);
        if (this._boostBadgeB != null)
            this._boostBadgeB.text = _0x995ce124._0x8e148fcd(new byte[1] { 190 }, 149);
        if (this._boostButton != null)
            this._boostButton.onClick.AddListener(() => this._0xaf87e36d());
        if (this._motionButton != null)
            this._motionButton.onClick.AddListener(() => this._0x2eaa9039());
        if (this._resetButton != null)
            this._resetButton.onClick.AddListener(() => this._0xe3fa2ca2());
        if (this._close != null)
            this._close.onClick.AddListener(() => this._0x2f4e3bb0());
        if (this._gate != null)
            this._gate._0x96c1aad5();
    }

    [SerializeField]
    private RectTransform _motionPreview;
    [SerializeField]
    private Image _boostPreviewA;
    [SerializeField]
    private TMP_Text _boostState;
    [SerializeField]
    private _0x25f9e005 _gate;
    [SerializeField]
    private TMP_Text _boostLabel;
}

internal static class _0x995ce124
{
    internal static string _0x8e148fcd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}
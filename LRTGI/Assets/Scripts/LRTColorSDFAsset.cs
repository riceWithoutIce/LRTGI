using UnityEngine;

[CreateAssetMenu(fileName = "LRTColorSDF", menuName = "LRT/ColorSDF Asset")]
public class LRTColorSDFAsset : ScriptableObject
{
	public Vector3 localBoundsMin;
	public Vector3 localBoundsMax;
	public int resolution = 16; // 推荐 16 或 32

	// 存储距离(R) 和 颜色(GB)
	// 如果需要更精细，可以使用 RGBA32，A 存储更高精度的距离
	public Texture3D sdfTexture;

	// 预计算的局部传输矩阵 (SH 2阶 = 4x4 矩阵)
	// 针对静态物件可以预存这个矩阵以节省运行时的 CPU 压力
	public float[] precomputedLTM;
}
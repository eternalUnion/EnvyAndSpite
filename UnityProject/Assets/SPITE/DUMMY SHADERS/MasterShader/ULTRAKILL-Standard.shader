Shader "ULTRAKILL/Master" {
	Properties {
		[MainProp] _Color ("Color", Vector) = (1,1,1,1)
		[MainProp] _MainTex ("Base (RGB)", 2D) = "white" {}
		[MainProp] _VertexWarpScale ("Vertex Warping Scalar", Range(0, 10)) = 1
		[MainProp] [Toggle] _Outline ("Assist Outline", Float) = 0
		[MainProp] [Enum(UnityEngine.Rendering.CullMode)] _CullMode ("Cull", Float) = 2
		[MainProp] [Toggle] _ZWrite ("ZWrite", Float) = 1
		[MainProp] [KeywordEnum(On, Off, Transparent)] _Fog ("Fog Mode", Float) = 0
		_Opacity ("Opacity", Range(0, 1)) = 1
		[Enum(Opaque,0,Cutout,1,Transparent,2,Advanced,3)] _BlendMode ("Blend Mode", Float) = 0
		[Toggle] _VertexLighting ("Vertex Lighting", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend ("Source Blend", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _DstBlend ("Dest Blend", Float) = 0
		[Keyword(CAUSTICS)] [NoScaleOffset] _Cells ("Cells", 2D) = "white" {}
		[Keyword(CAUSTICS)] [NoScaleOffset] _Perlin ("Perlin", 2D) = "white" {}
		[Keyword(CAUSTICS)] _CausticColor ("Caustics Color", Vector) = (1,1,1,1)
		[Keyword(CAUSTICS)] _Scale ("World Scale", Float) = 1
		[Keyword(CAUSTICS)] _Falloff ("Mask Falloff", Float) = 1
		[Keyword(CAUSTICS)] _Speed ("Speed", Float) = 0.5
		[Keyword(CUSTOM_COLORS, REFLECTION)] _CubeTex ("Cube Texture", Cube) = "_Skybox" {}
		[Keyword(CUSTOM_COLORS, REFLECTION)] _ReflectionStrength ("Reflection Strength", Float) = 1
		[Keyword(CUSTOM_COLORS)] _IDTex ("ID Texture", 2D) = "white" {}
		[Keyword(CUSTOM_COLORS)] _CustomColor1 ("Custom Color 1", Vector) = (1,1,1,1)
		[Keyword(CUSTOM_COLORS)] _CustomColor2 ("Custom Color 2", Vector) = (1,1,1,1)
		[Keyword(CUSTOM_COLORS)] _CustomColor3 ("Custom Color 3", Vector) = (1,1,1,1)
		[Keyword(CUSTOM_COLORS)] _ReflectionFalloff ("Reflection Falloff", Float) = 1
		[Keyword(CUSTOM_LIGHTMAP)] _LightMapTex ("Light Map Texture", 2D) = "white" {}
		[Keyword(BLOOD_ABSORBER] [NoScaleOffset] _BloodTex ("BloodTex", 2D) = "black" {}
		[Keyword(BLOOD_FILLER)] _BloodNoiseTex ("Blood Noise Texture", 2D) = "white" {}
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveColor ("Emissive Color", Vector) = (1,1,1,1)
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveTex ("Emissive Texture", 2D) = "white" {}
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveIntensity ("Emissive Strength", Float) = 1
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveSaturation ("Emissive Saturation", Float) = 1
		[Keyword(CYBER_GRIND, EMISSIVE)] [Toggle] _UseAlbedoAsEmissive ("Use Albedo As Emissive", Float) = 1
		[Keyword(CYBER_GRIND, EMISSIVE)] [Toggle] _EmissiveReplaces ("Emissive Replaces Instead of Adding to Underlying Color", Float) = 0
		[Keyword(CYBER_GRIND)] _GradientFalloff ("Gradient Falloff", Float) = 1
		[Keyword(CYBER_GRIND)] _GradientScale ("Gradient Scale", Float) = 1
		[Keyword(CYBER_GRIND)] _GradientSpeed ("Gradient Speed", Float) = 1
		[Keyword(CYBER_GRIND)] [Toggle] _PCGamerMode ("PC Gamer Mode", Float) = 0
		[Keyword(CYBER_GRIND)] _RainbowDensity ("Rainbow Density", Float) = 1
		[Keyword(FRESNEL)] _FresnelColor ("Fresnel Color", Vector) = (1,1,1,1)
		[Keyword(FRESNEL)] _FresnelStrength ("Fresnel Strength", Float) = 1
		[Keyword(RADIANCE)] _InflateStrength ("Inflate Strength", Float) = 1
		[Keyword(SCROLLING)] _ScrollSpeed ("Scroll Speed", Vector) = (0,0,0,0)
		[Keyword(VERTEX_DISPLACEMENT)] _VertexNoiseTex ("Vertex Noise Texture Lookup", 2D) = "black" {}
		[Keyword(VERTEX_DISPLACEMENT)] _VertexNoiseScale ("Vertex Distortion Density", Range(0, 10)) = 1
		[Keyword(VERTEX_DISPLACEMENT)] _VertexNoiseSpeed ("Vertex Distortion Speed", Range(0, 10)) = 1
		[Keyword(VERTEX_DISPLACEMENT)] _VertexNoiseAmplitude ("Vertex Distortion Amplitude", Range(0, 50)) = 1
		[Keyword(VERTEX_DISPLACEMENT)] _VertexScale ("Vertex Inflation Scale", Range(0, 1)) = 0
		[Keyword(VERTEX_DISPLACEMENT)] _FlowDirection ("Vertex Distortion Flow Direction (Normalized XYZ)", Vector) = (0,1,0,1)
		[Keyword(VERTEX_DISPLACEMENT)] [Toggle] _ReverseFlow ("Reverse Flow", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [Toggle] _LocalOffset ("Use Local Space Offset", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [Toggle] _RecalculateNormals ("Recalculate Normals", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] _NormalOffsetScale ("Normal Offset Scale", Float) = 1
	}
	SubShader {
		Tags { "LIGHTMODE" = "Vertex" "RenderType" = "Opaque" }
		Pass {
			Tags { "LIGHTMODE" = "Vertex" "RenderType" = "Opaque" }
			Blend Zero Zero, Zero Zero
			ZWrite Off
			Cull Off
			GpuProgramID 1969
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float4 color : COLOR0;
				float4 color1 : COLOR1;
				float2 texcoord : TEXCOORD0;
				float texcoord5 : TEXCOORD5;
				float3 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float3 texcoord3 : TEXCOORD3;
				float4 texcoord9 : TEXCOORD9;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
				float2 sv_target1 : SV_Target1;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_ST;
			float4 _Color;
			float4 unity_FogEnd;
			float4 unity_FogStart;
			float _TextureWarping;
			float _VertexWarping;
			float _VertexWarpScale;
			// $Globals ConstantBuffers for Fragment Shader
			bool _ForceOutline;
			bool _HasSandBuff;
			float _OiledAmount;
			float _Outline;
			float _ShouldForceOutlines;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _SandTex;
			sampler2D _OilTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0.x = max(_ScreenParams.y, _ScreenParams.x);
                tmp0.xy = _ScreenParams.xy / tmp0.xx;
                tmp1.xyz = v.vertex.yyy * unity_ObjectToWorld._m01_m11_m21;
                tmp1.xyz = unity_ObjectToWorld._m00_m10_m20 * v.vertex.xxx + tmp1.xyz;
                tmp1.xyz = unity_ObjectToWorld._m02_m12_m22 * v.vertex.zzz + tmp1.xyz;
                tmp1.xyz = unity_ObjectToWorld._m03_m13_m23 * v.vertex.www + tmp1.xyz;
                tmp2.xyz = _WorldSpaceCameraPos - tmp1.xyz;
                tmp0.z = dot(tmp2.xyz, tmp2.xyz);
                tmp0.w = sqrt(tmp0.z);
                tmp0.z = rsqrt(tmp0.z);
                tmp3.xyz = tmp0.zzz * tmp2.xyz;
                tmp0.z = tmp0.w - 200.0;
                tmp0.w = unity_FogEnd.x - tmp0.w;
                tmp0.z = max(tmp0.z, 0.0);
                tmp0.z = log(tmp0.z);
                tmp0.z = tmp0.z * 0.2;
                tmp0.z = exp(tmp0.z);
                tmp0.z = tmp0.z * 0.1 + _VertexWarpScale;
                tmp0.z = tmp0.z * _VertexWarping;
                tmp0.xy = tmp0.zz * tmp0.xy;
                tmp4 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp4 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp4;
                tmp4 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp4;
                o.texcoord1.xyz = tmp1.xyz;
                tmp1 = tmp4 + unity_MatrixVP._m03_m13_m23_m33;
                tmp4.xyz = tmp1.xyz / tmp1.www;
                tmp5.xy = tmp0.xy * tmp4.xy;
                tmp5.xy = floor(tmp5.xy);
                tmp5.xy = tmp5.xy + float2(0.5, 0.5);
                tmp4.xy = tmp5.xy / tmp0.xy;
                tmp0.xyz = tmp1.www * tmp4.xyz;
                tmp2.w = _VertexWarping != 0.0;
                tmp1.xyz = tmp2.www ? tmp0.xyz : tmp1.xyz;
                tmp0.x = max(tmp1.w, 0.02);
                tmp0.x = tmp0.x - 0.5;
                o.position = tmp1;
                o.color.xyz = v.color.xyz * _Color.xyz;
                o.color.w = v.color.w;
                tmp0.y = unity_FogEnd.x - unity_FogStart.x;
                o.color1.w = saturate(tmp0.w / tmp0.y);
                o.color1.xyz = unity_FogColor.xyz;
                tmp0.y = min(_TextureWarping, 1.0);
                tmp0.y = tmp0.y * 0.5;
                tmp0.x = tmp0.y * tmp0.x + 0.5;
                tmp0.yz = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                o.texcoord.xy = tmp0.xx * tmp0.yz;
                o.texcoord5.x = tmp0.x;
                tmp0.x = dot(v.normal.xyz, unity_WorldToObject._m00_m10_m20);
                tmp0.y = dot(v.normal.xyz, unity_WorldToObject._m01_m11_m21);
                tmp0.z = dot(v.normal.xyz, unity_WorldToObject._m02_m12_m22);
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp0.w = dot(-tmp2.xyz, tmp0.xyz);
                tmp0.w = tmp0.w + tmp0.w;
                tmp2.xyz = tmp0.xyz * -tmp0.www + -tmp2.xyz;
                tmp0.w = dot(tmp2.xyz, tmp2.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp4.xyz = tmp2.xyz * tmp0.www + -tmp2.xyz;
                tmp0.w = _TextureWarping + _TextureWarping;
                tmp0.w = min(tmp0.w, 1.0);
                o.texcoord2.xyz = tmp0.www * tmp4.xyz + tmp2.xyz;
                tmp0.w = dot(tmp0.xyz, tmp3.xyz);
                o.texcoord3.xyz = tmp0.xyz;
                tmp0.x = 1.0 - abs(tmp0.w);
                tmp0.x = dot(tmp0.xy, tmp0.xy);
                o.texcoord2.w = min(tmp0.x, 1.0);
                tmp0.xz = tmp1.xw * float2(0.5, 0.5);
                o.texcoord9.zw = tmp1.zw;
                tmp0.y = tmp1.y * _ProjectionParams.x;
                tmp0.w = tmp0.y * 0.5;
                o.texcoord9.xy = tmp0.zz + tmp0.xw;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                tmp0.xy = inp.texcoord.xy / inp.texcoord5.xx;
                tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                o.sv_target.w = tmp0.w * inp.color.w;
                tmp1.xyz = tmp0.xyz * inp.color.xyz;
                if (_HasSandBuff) {
                    tmp0.w = dot(inp.texcoord3.xyz, inp.texcoord3.xyz);
                    tmp0.w = rsqrt(tmp0.w);
                    tmp2.xyz = tmp0.www * inp.texcoord3.xyz;
                    tmp3 = _Time * float4(0.1, 0.5, 0.5, 0.1) + inp.texcoord1.xyyz;
                    tmp2.xw = max(abs(tmp2.zy), abs(tmp2.xx));
                    tmp2.xy = tmp2.xw < abs(tmp2.yz);
                    tmp2.xzw = tmp2.xxx ? float3(0.0, 1.0, 0.0) : float3(1.0, 0.0, 0.0);
                    tmp2.xyz = tmp2.yyy ? float3(0.0, 0.0, 1.0) : tmp2.xzw;
                    tmp4 = tmp2.zzxx * tmp3;
                    tmp2.xz = tmp4.zw + tmp4.xy;
                    tmp2.xy = tmp3.xw * tmp2.yy + tmp2.xz;
                    tmp2.xy = tmp2.xy * float2(0.25, 0.25);
                    tmp2 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                    tmp0.w = rsqrt(inp.texcoord2.w);
                    tmp0.w = 1.0 / tmp0.w;
                    tmp1.w = tmp0.w * 0.75 + 0.25;
                    tmp0.xyz = -tmp0.xyz * inp.color.xyz + tmp2.xyz;
                    tmp0.xyz = tmp1.www * tmp0.xyz + tmp1.xyz;
                    tmp2.xyz = tmp0.www * tmp2.xyz;
                    tmp1.xyz = tmp2.xyz * float3(0.75, 0.75, 0.75) + tmp0.xyz;
                }
                tmp0.xy = inp.texcoord2.xy * float2(0.05, 0.05);
                tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                tmp2.x = tmp0.x + inp.texcoord2.w;
                tmp2.y = tmp0.x * 5.0;
                tmp0 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                tmp0.w = log(inp.texcoord2.w);
                tmp0.w = tmp0.w * 0.75;
                tmp0.w = exp(tmp0.w);
                tmp0.w = saturate(tmp0.w * 3.0 + -0.2);
                tmp0.xyz = tmp0.www * tmp0.xyz + -tmp1.xyz;
                o.sv_target.xyz = _OiledAmount.xxx * tmp0.xyz + tmp1.xyz;
                tmp0.x = _ForceOutline ? 0.5 : 0.0;
                o.sv_target1.x = max(tmp0.x, _Outline);
                o.sv_target1.y = _ShouldForceOutlines;
                return o;
			}
			ENDCG
		}
	}
	CustomEditor "ULTRAShaderEditor"
}
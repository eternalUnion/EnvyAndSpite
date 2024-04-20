Shader "ULTRAKILL/Particles/Additive" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_EmissionColor ("Emission Color", Vector) = (0,0,0,1)
		_Strength ("Strength Multiplier", Float) = 1
		_MainTex ("Texture", 2D) = "white" {}
		[Toggle] _ShouldForceOutlines ("Should Outline Objects Behind", Float) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 2
	}
	SubShader {
		LOD 100
		Tags { "LIGHTMODE" = "FORWARDBASE" "PASSFLAGS" = "OnlyDirectional" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		Pass {
			LOD 100
			Tags { "LIGHTMODE" = "FORWARDBASE" "PASSFLAGS" = "OnlyDirectional" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend 0 SrcAlpha One, SrcAlpha One
			Blend 1 OneMinusDstColor One, OneMinusDstColor One
			BlendOp 1 Max, Max
			ZWrite Off
			Cull Off
			GpuProgramID 44974
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float2 texcoord : TEXCOORD0;
				float4 position : SV_POSITION0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
				float2 sv_target1 : SV_Target1;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_ST;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _Color;
			float4 _EmissionColor;
			float _ShouldForceOutlines;
			float _Strength;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                o.texcoord.xy = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp0 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp1 = tmp0.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp1 = unity_MatrixVP._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_MatrixVP._m02_m12_m22_m32 * tmp0.zzzz + tmp1;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp0.wwww + tmp1;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp0 = tmp0 * _Color;
                tmp0.xyz = tmp0.xyz * _EmissionColor.xyz;
                tmp0 = tmp0 * _Strength.xxxx;
                o.sv_target = tmp0;
                tmp0.x = dot(tmp0.xyz, float3(0.333, 0.333, 0.333));
                tmp0.x = tmp0.x * tmp0.w + -0.001;
                tmp0.x = ceil(tmp0.x);
                o.sv_target1.y = tmp0.x * _ShouldForceOutlines;
                o.sv_target1.x = 0.0;
                return o;
			}
			ENDCG
		}
	}
}
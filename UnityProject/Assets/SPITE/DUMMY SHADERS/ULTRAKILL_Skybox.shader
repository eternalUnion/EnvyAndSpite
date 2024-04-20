Shader "ULTRAKILL/Skybox" {
	Properties {
		_RotateSky ("Sky Rotation", Range(0, 1)) = 0
		[KeywordEnum(Panorama, Cubemap)] _TexMode ("Texture Type", Float) = 0
		_MainTex ("Texture", 2D) = "white" {}
		_Cubemap ("Cubemap", Cube) = "hiwte" {}
		[IntRange] _SkyTile ("Pano Sky Latitude Tile", Range(1, 4)) = 4
		_SkyHeightOffset ("Pano Sky Height Offset", Float) = 0.5
		_SkyStretch ("Pano Sky Stretch", Float) = 1
		_SkyTopSharpness ("Pano Sky Top Sharpness", Float) = 4
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}
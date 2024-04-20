Shader "ULTRAKILL/bloodstain" {
	Properties {
		_SplatterAtlas ("Atlas", 2D) = "white" {}
		[PerRendererData] _Index ("UV Index", Float) = 1
		_VertexWarpScale ("Vertex Warping Scalar", Range(0, 10)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
}
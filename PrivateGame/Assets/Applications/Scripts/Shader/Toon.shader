Shader "Custom/Toon" {
	Properties {
        _Color ("Color", Color) = (1,1,1,1)
      // _MainTex ("Albedo (RGB)", 2D) = "white" {}
       // _OutLine ("OutLine", float) = 0.25
    }
    SubShader {
       
       Pass {
            Tags { "RenderType"="Opaque" }

            CGPROGRAM
            
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            
            //uniform sampler2D _MainTex;
            uniform float4 _Color;
           //uniform float _OutLine;
            
            struct appdata {
                float4 vertex : POSITION;
                //float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };
            
            struct v2f {
                float4 vertex : SV_Target;
                //float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };
            
            // 頂点シェーダ
            v2f vert (appdata v) {
            
                v2f o;
                
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
               // o.normal = v.normal;
                
                return o;
            }
            
            // フラグメントシェーダ
            fixed4 frag(v2f i) : SV_Target {
                
              //  fixed4 col = tex2D(_MainTex, i.uv);
                
                return fixed4(1,1,1,1);
            }
            
            ENDCG
       }
    }
}
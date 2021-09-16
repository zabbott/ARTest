Shader "Custom/Portal2"
{
	SubShader 
	{
		ZWrite Off
		ColorMask 0

		Stencil{
		Ref 1
		Pass replace
	}

		Pass
		{

}
	}

}

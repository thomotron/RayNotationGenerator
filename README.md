# RayNotationGenerator
<img src="https://i.imgur.com/p5PTYlV.png"></img>

Encodes a string of Unicode characters into Ray Notation image.

## 'Ray notation'?
It's something I came up with when learning about binary and playing around with different ways of representing it visually.  
Each byte is represented by a single character with eight possible 'ray' positions extending from the centre and rotating clockwise from the top with the least significant bit first. Each ray is drawn only if that bit is set to 1, otherwise that ray is not drawn and leaves a gap.  
For example, the image above reads 'Ray Notation' when encoded with UTF-8.  
The raw binary representation of the first three ray characters would be `01010010 01100001 01111001`

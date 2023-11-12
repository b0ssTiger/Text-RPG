using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Shop
    {
        public Shop(Item[] items)
        {
            Items = items;
        } //샵에 대한 생성자!!!!! 
        // ex)음식점 - 메뉴판 좌석 
        // 무기 총 칼 다이너마이트 장식 해결
        public Item[] Items; // 어디서든 불러 올 수 있다. 프라이빗?!! 
    }
}

//장비아이템 착용여부 + 던전만들기 
    
//무기상점 
// LV.1 몽둥이 LV.5 칼  LV.15 총  LV.30 샷건? 총 종류 알아보기 

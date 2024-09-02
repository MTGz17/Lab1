using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChessPiece : MonoBehaviour
{
    public Sprite[] Pieces;
    public enum Piece
    {
        Rook,
        Knight,
        Bishop,
        Queen,
        King,
        Pawn
    }
    public Piece piece;

    void Start()
    {
        switch(piece)
        {
            case Piece.Rook:
                gameObject.GetComponent<SpriteRenderer>().sprite = Pieces[0];
                break;
            case Piece.Knight:
                gameObject.GetComponent<SpriteRenderer>().sprite = Pieces[1];
                break;
            case Piece.Bishop:
                gameObject.GetComponent<SpriteRenderer>().sprite = Pieces[2];
                break;
            case Piece.Queen:
                gameObject.GetComponent<SpriteRenderer>().sprite = Pieces[3];
                break;
            case Piece.King:
                gameObject.GetComponent<SpriteRenderer>().sprite = Pieces[4];
                break;
            case Piece.Pawn:
                gameObject.GetComponent<SpriteRenderer>().sprite = Pieces[5];
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

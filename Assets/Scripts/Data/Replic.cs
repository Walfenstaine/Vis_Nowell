using UnityEngine;

[CreateAssetMenu(fileName = "Replic", menuName = "ScriptableObjects/Replics", order = 3)]
public class Replic : ScriptableObject
{
    [System.Serializable]
    public class Replics
    {
        [Tooltip("��� ���������� �����")]
        public TipeOfTale tip;
        [Tooltip("������������ ������� (����� �������� ������)")]
        public string trigger;
        public enum TipeOfTale {quest, masage, death, dan}
        [System.Serializable]
        public class Questions
        {
            
            [field: TextArea(2, 5)]
            [field: SerializeField] public string quest { get; private set; }
            [Tooltip("����� �����")]
            public int number_vet;

        }
        [Tooltip("�������� �������")]
        public Questions[] questions;

        
        [field: TextArea(5, 5)]
       
        [field: SerializeField]
        public string masage { get; private set; }

        


    }
    public Replics[] nodes;
}

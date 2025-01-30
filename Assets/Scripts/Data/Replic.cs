using UnityEngine;

[CreateAssetMenu(fileName = "Replic", menuName = "ScriptableObjects/Replics", order = 3)]
public class Replic : ScriptableObject
{
    [System.Serializable]
    public class Replics
    {
        public enum TipeOfTale {quest, masage, death, dan}
        public TipeOfTale tip;
        public string trigger;
        public int[] number_vet;
        [field: TextArea(5, 5)]
        [field: SerializeField] public string masage { get; private set; }

        [field: TextArea(5, 5)]
        [field: SerializeField] public string[] quest { get; private set; }


    }
    public Replics[] nodes;
}

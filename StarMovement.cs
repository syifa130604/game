using UnityEngine;

public class StarMovement : MonoBehaviour
{
    public float starSpeed = 2f; 

    // Fungsi Start dijalankan satu kali saat bintang muncul
    void Start()
    {
        // Mengecilkan ukuran bintang secara acak agar bervariasi
        float ukuranAcak = Random.Range(0.02f, 0.08f);
        transform.localScale = new Vector3(ukuranAcak, ukuranAcak, 1);
    }

    // Fungsi Update dijalankan setiap frame (hanya boleh ada SATU fungsi Update)
    void Update()
    {
        // Menggerakkan bintang ke kiri
        transform.Translate(Vector3.left * starSpeed * Time.deltaTime);

        // Menghapus bintang jika sudah keluar layar
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}

public void Hit ()
{
   
    brokenBlockLeft.SetActive(true);
    brokenBlockRight.SetActive(true);
    
    brokenBlockLeft.transform.parent = null;
    brokenBlockRight.transform.parent = null;
    
    Rigidbody leftRig = brokenBlockLeft.GetComponent<Rigidbody>();
    Rigidbody rightRig = brokenBlockRight.GetComponent<Rigidbody>();
    leftRig.AddForce(-transform.right * brokenBlockForce, ForceMode.Impulse);
    rightRig.AddForce(transform.right * brokenBlockForce, ForceMode.Impulse);
    
    leftRig.AddTorque(-transform.forward * brokenBlockTorque, ForceMode.Impulse);
    rightRig.AddTorque(transform.forward * brokenBlockTorque, ForceMode.Impulse);
   
    Destroy(brokenBlockLeft, brokenBlockDestroyDelay);
    Destroy(brokenBlockRight, brokenBlockDestroyDelay);
   
    Destroy(gameObject);
}
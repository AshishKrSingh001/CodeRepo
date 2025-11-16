class fileProperty{
	public static void main(String[] args)
	{
		String fname=args[0];
		File f=new File(fname);
		System.out.println("File name "+f.getName());
		
	}
}
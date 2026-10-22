import 'package:flutter/material.dart';

class testing7 extends StatefulWidget {
  const testing7({super.key});

  @override
  State<testing7> createState() => _testing7State();
}

class _testing7State extends State<testing7> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Button Example"),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          ElevatedButton(onPressed: (){}, child: Text("Elevated Button")),
          const SizedBox(height: 10,),

          TextButton(onPressed: (){}, child: Text("Text Button")),
          const SizedBox(height: 10,),
          
          OutlinedButton(onPressed: (){}, child: Text("Outline Button")),
          const SizedBox(height: 10,),

          ElevatedButton(onPressed: (){}, child: Icon(Icons.add_box_rounded)),
          const SizedBox(height: 10,),

          ElevatedButton(onPressed: (){}, child: SizedBox(
            width: 100,
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Icon(Icons.add_box_rounded),
                const SizedBox(width: 10,),
                Text('Add')
              ],
            ),
          )
          ),
          const SizedBox(
            height: 10,
          ),
          
          GestureDetector(
            onTap: (){
              print("Tap");
            },
            
            onLongPress: (){
              print("long press");
            },
            
            onDoubleTap: (){
              print("Double Tap");
            },
            child: Text("Gesture Detector"),
          ),
          InkWell(
            onTap: (){
              print("InkWell Tapped");
            },
            
            borderRadius: BorderRadius.circular(8),
            child: Container(
              padding: EdgeInsets.all(16),
              decoration: BoxDecoration(
                color: Colors.amber,
                borderRadius: BorderRadius.circular(8),
              ),
              child: Text("Inkwell (with ripple)"),
            ),
          ),
          InkResponse(
            onTap: (){
              print("InkResponse Tapped!");
            },
            radius: 30,
            child: Icon(Icons.favorite, size: 40, color: Colors.red,
            ),
          ),
          GestureDetector(
            onTap: (){
              print("Image tapped");
            },
            child: Image.network("https://picsum.photos/200",
            width: 120,
            height: 120,),


          ),
          Container(
            decoration: BoxDecoration(
              border: Border.all(
                color: Colors.blue,
                style: BorderStyle.solid,
                width: 2,
              ),
              borderRadius: BorderRadius.circular(20)
            ),
            child: ListTile(
              leading: Icon(Icons.person),
              title: Text("Profile"),
              subtitle: Text("go to profile page"),
              trailing: const Icon(Icons.arrow_forward_ios),
              onTap: (){
                print("List Tapped");
              },
            ),
          )
          

        ],
      ),
      floatingActionButton: FloatingActionButton(onPressed: (){},child: Icon(Icons.add),),
    );
  }
}

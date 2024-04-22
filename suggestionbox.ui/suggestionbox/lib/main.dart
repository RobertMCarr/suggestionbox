import 'package:flutter/material.dart';
import 'package:suggestionbox/pages/auth_page.dart';
import 'package:supabase_flutter/supabase_flutter.dart';

const supabaseUrl = 'https://ohtpodvpzzwbqzmqnxto.supabase.co';
const supabaseAnonKey =
    'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im9odHBvZHZwenp3YnF6bXFueHRvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTI2Njg1NzcsImV4cCI6MjAyODI0NDU3N30.3Ap06ZKOgf3RpwYu3Dk18drbM9GAVWoNHx3uorYKIj4';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();
  
  await Supabase.initialize(
    url: supabaseUrl,
    anonKey: supabaseAnonKey,
  );

  runApp(const SuggestionBoxApp());
}

class SuggestionBoxApp extends StatelessWidget {
  const SuggestionBoxApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return const MaterialApp(
      debugShowCheckedModeBanner: false,
      home: AuthPage(),
    );
  }
}

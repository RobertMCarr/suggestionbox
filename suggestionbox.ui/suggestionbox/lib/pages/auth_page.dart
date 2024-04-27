import 'package:flutter/material.dart';
import 'package:suggestionbox/pages/home_page.dart';
import 'package:suggestionbox/pages/login_page.dart';
import 'package:supabase_flutter/supabase_flutter.dart';

class AuthPage extends StatelessWidget {
  const AuthPage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: StreamBuilder<AuthState?>(
      stream: Supabase.instance.client.auth.onAuthStateChange,
      builder: (event, session) {
        if (session.hasData && session.data!.session != null) {
          return const HomePage();
        } else {
          return LoginPage();
        }
      },
    ));
  }
}

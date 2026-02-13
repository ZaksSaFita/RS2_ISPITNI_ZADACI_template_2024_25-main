import 'dart:convert';

import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/user_activity.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class ActivityProvider extends BaseProvider<UserActivity> {
  ActivityProvider() : super("userActivityBrojIndeksa");

  @override
  UserActivity fromJson(dynamic json) {
    return UserActivity.fromJson(json);
  }
}

class ActivityBrojIndeksaProvider extends BaseProvider<ActivityBrojIndeksa> {
  ActivityBrojIndeksaProvider() : super("userActivityBrojIndeksa");

  @override
  ActivityBrojIndeksa fromJson(dynamic json) {
    return ActivityBrojIndeksa.fromJson(json);
  }
}

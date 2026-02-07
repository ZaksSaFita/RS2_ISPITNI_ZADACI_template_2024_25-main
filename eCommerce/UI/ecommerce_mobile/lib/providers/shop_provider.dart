import 'dart:convert';

import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/model/shop.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class ShopProvider extends BaseProvider<ShopCart> {
  ShopProvider() : super("cart");

  @override
  ShopCart fromJson(dynamic json) {
    return ShopCart.fromJson(json);
  }

  Future<ShopCart> addToCart(int id, [dynamic request]) async {
    var url = "https://localhost:7093/api/Cart/$id/addToCart";
    var uri = Uri.parse(url);
    var headers = createHeaders();

    var jsonRequest = jsonEncode(request);
    var response = await http.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      throw new Exception("Unknown error");
    }
  }
}

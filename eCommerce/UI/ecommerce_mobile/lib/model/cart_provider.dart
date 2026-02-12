import 'dart:convert';

import 'package:ecommerce_mobile/model/cart.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class CartProvider extends BaseProvider<Cart> {
  CartProvider() : super("cart");

  @override
  Cart fromJson(dynamic json) {
    return Cart.fromJson(json);
  }

  Future<void> removeFromCart(int id) async {
    var url = "https://localhost:7093/api/Cart/removeItem/$id";
    var uri = Uri.parse(url);
    var headers = createHeaders();

    var response = await http.delete(uri, headers: headers);

    if (isValidResponse(response)) {
    } else {
      throw new Exception("Unknown error");
    }
  }

  Future addToCart(dynamic request) async {
    var url = "https://localhost:7093/api/Cart/addToCart";

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
